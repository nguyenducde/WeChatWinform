using Chat_Application_DaiHocDaLat.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application_DaiHocDaLat.Views
{
    public partial class MainClient : MaterialForm
    {
        private static readonly Socket clientSocket = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    
        frm_ChatUser user;
        ChatRoom nameroom;
        List<frm_ChatUser> lv_ChatUser = new List<frm_ChatUser>();
        List<ChatRoom> lv_ChatRoom = new List<ChatRoom>();

      
        public static Socket ClientSocket
        {
            get
            {
                return clientSocket;
            }
        }


        public MainClient(String user)
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan500, Primary.DeepOrange800, Accent.Cyan700, TextShade.BLACK);
           CheckForIllegalCrossThreadCalls = false;
            //Hiển thị tên người dùng
            Text = user;
            ConnectToServer();
            DisplayNameRoom();
            DisplayMemberOffline();
        }

     

        //Khi chọn người online thì hiện lên form chat riêng
        private void lb_ClientOnline_SelectedIndexChanged(object sender, EventArgs e)
        {
            try  {
                String mess = "";
                user = new frm_ChatUser();
                lv_ChatUser.Add(user);
                user.DisplayUser(Text, lb_ClientOnline.Items[lb_ClientOnline.SelectedIndex].ToString(), mess);
                user.Show();
            }
            catch
            {
            }
            
        }

      

        //Khi nhấn vào send thì gửi tin nhắn
        private void btnSend_Click(object sender, EventArgs e)
        {
           
            if(txtChat.Text!="")
            {
                ClientSocket.Send(PhanManh(Text + ": " + txtChat.Text));
                txtChat.Text = "";
            }
        }



        ///////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////Phần chung/////////////////////////////////////////////


        //Phân mảnh và gom mảnh data để gửi và nhận thông tin
        byte[] PhanManh(object data)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
            return stream.ToArray();
        }
        object GomManh(byte[] data)
        {
            MemoryStream steam = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(steam);
        }



        //Ngắt kết nối
        void disConnect()
        {
            ClientSocket.Send(PhanManh( Text + " ngắt kết nối $$"));
          ClientSocket.Close();
        }
        //Tắt chương trình
        private void MainClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            disConnect();
        }


        public void ConnectToServer()
        {
            while (!ClientSocket.Connected)
            {
                try
                {
                    ClientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                    ClientSocket.Send(PhanManh(Text + ": Đã kêt nối@@"));
                }
                catch (SocketException)
                {
                    MessageBox.Show("Không thể két nối server");
                    clientSocket.Close();
                }
            }
            lv_ChatClient.Items.Add("Kết nối server thành công");

            //Lắng nghe khi server gửi tin
            Thread listen = new Thread(ReceiveResponse);
            listen.IsBackground = true;
            listen.Start();
        }


        //Nhận tin nhắn
        public void ReceiveResponse()
        {
            while (true)
            {
                var buffer = new byte[2048];
                try
                {
                    ClientSocket.Receive(buffer);
                    string message = (string)GomManh(buffer);
                    //Hiện danh sách client online
                    if (message.Contains("@@"))
                    {
                       
                        int check = lb_ClientOnline.FindString(message.Remove(0, 2).Substring(0, 5));
                     
                        if (check == -1)
                        {
                            lb_ClientOnline.Items.Add(message.Remove(0, 2).Substring(0, 5)+" đang online");
                          
                        }
                        else
                        {
                            lb_ClientOnline.Items.Remove(message.Remove(0, 2).Substring(0, 5));
                            if (lb_ClientOnline.FindString(message.Remove(0, 2).Substring(0, 5) + " đang online") == -1)
                            {
                                lb_ClientOnline.Items.Add(message.Remove(0, 2).Substring(0, 5) + " đang online");
                            }
                        }
                       
                    }
                    //Chat client to client
                    else if (message.Contains("ChatClient"))
                    {
                        for (int i = 0; i < lv_ChatUser.Count; i++)
                        {
                            if(lv_ChatUser[i].Text!="")
                            {
                                lv_ChatUser[i].getChatUser(message);
                            }
                            
                        }
                    }

                    
                    //Chat room
                    else if (message.Contains("CchatRooomm"))
                    {
                        for (int i = 0; i < lv_ChatRoom.Count; i++)
                        {
                            if (lv_ChatRoom[i].Text != "")
                            {
                                lv_ChatRoom[i].getMessChatRoom(message);
                            }
                        }
                    }
                    //Thêm bạn bè vào room
                    else if(message.Contains("BzboxThongbao"))
                    {
                        MessageBox.Show("Một người bạn của bản đã thêm bạn vào nhóm "+message.Substring(0,7));
                    }
                    else if (message.Contains("ServerClosed"))
                    {
                        this.Close();
                    }
                    //Chat Server
                    else
                    {
                        lv_ChatClient.Items.Add(message);
                    }
                }
                catch (Exception)
                {

                    clientSocket.Close();
                }
                
            }
        }

        public void DisplayMemberOffline()
        {

            Task.Run(async () => {
                for (;;)
                {

                    await Task.Delay(5000);
                    DataTable Data = BllClient.Instance.Client.DisplayClientOffline();
                    foreach (DataRow dtRow in Data.Rows)
                    {
                        String name = dtRow.ItemArray[0].ToString();
                        int check = lb_ClientOnline.FindString(name);
                        if (check == -1)
                        {
                            lb_ClientOnline.Items.Add(name);
                        }


                    }
                }
            });
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////End Phần chung/////////////////////////////////////////
      



        /////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////Chat Nhom//////////////////////////////////////////////////
        public void DisplayNameRoom()
        {
            Task.Run(async () => {
                for (;;)
                {
                    await Task.Delay(5000);
                    lb_List_Room.Items.Clear();
                    DataTable Data = BllClient.Instance.Client.DisPlayNameRoom();
                    foreach (DataRow dtRow in Data.Rows)
                    {
                        String nameroom = dtRow.ItemArray[0].ToString();
                        int result = lb_List_Room.FindString(nameroom);
                       if (result==-1)
                        {
                            lb_List_Room.Items.Add(dtRow.ItemArray[0]);
                        }
                       

                    }
                }
            });
        }

        private void lb_List_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                String nameRoom = lb_List_Room.Items[lb_List_Room.SelectedIndex].ToString();
                nameroom = new ChatRoom();
                lv_ChatRoom.Add(nameroom);
                nameroom.DisplayUserChatRoom(Text, nameRoom);
                //if (BllClient.Instance.Client.checkClientNameRoom(nameRoom, Text))
                //{
                //}
                //else
                //{
                //    BllClient.Instance.Client.insertClientRoom(nameRoom, Text);

                //}
                nameroom.Show();
            }catch
            {
                
            }
            

        }

       

        

        private void bunifuosSwitch_OnValueChange(object sender, EventArgs e)
        {

            if (bunifuosSwitch.Value == true)
            {
                this.BackColor = Color.FromArgb(34, 36, 49);
                lv_ChatClient.BackColor = Color.FromArgb(34, 36, 49);
                lb_ClientOnline.BackColor = Color.FromArgb(34, 36, 49);
                lb_List_Room.BackColor = Color.FromArgb(34, 36, 49);
                txtChat.BackColor = Color.FromArgb(34, 36, 49);
                lv_ChatClient.ForeColor = Color.White;
                lb_ClientOnline.ForeColor = Color.White;
                lb_List_Room.ForeColor = Color.White;
                txtChat.ForeColor = Color.White;
                lbOnl.ForeColor = Color.White;
                lbDarkmode.ForeColor = Color.White;
                lbCreate.ForeColor = Color.White;
                lbListRoom.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                lv_ChatClient.BackColor = Color.White;
                lb_ClientOnline.BackColor = Color.White;
                lb_List_Room.BackColor = Color.White;
                txtChat.BackColor = Color.White;
                lv_ChatClient.ForeColor = Color.Black;
                lb_ClientOnline.ForeColor = Color.Black;
                lb_List_Room.ForeColor = Color.Black;
                txtChat.ForeColor = Color.Black;
                lbOnl.ForeColor = Color.Black;
                lbDarkmode.ForeColor = Color.Black;
                lbCreate.ForeColor = Color.Black;
                lbListRoom.ForeColor = Color.Black;
            }
        }

        private void lbCreate_Click_1(object sender, EventArgs e)
        {
            FrmCreateRoom frm = new FrmCreateRoom();
            frm.Show();
        }

        private void lv_ChatClient1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
