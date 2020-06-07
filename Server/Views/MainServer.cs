using Server.BLL;
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

namespace Server.Views
{
    public partial class MainServer : Form
    {
        public MainServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            SetupServer();
            DisplayClientOnline();


        }

        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 100;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        private void Main_Load(object sender, EventArgs e)
        {

        }
       
        //Gửi tin nhắn all
        private void btnSend_Click(object sender, EventArgs e)
        {
            
            for(int i=0;i<clientSockets.Count;i++)
            {
                clientSockets[i].Send(PhanManh("Server: "+txtChat.Text));
               
            }
            lvChatServer.Items.Add("Server: " + txtChat.Text);
            txtChat.Text = "";
        }


        private void SetupServer()
        {
             lvChatServer.Items.Add("Đang cài đặt server");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(0);
            serverSocket.BeginAccept(AcceptCallback, null);
            lvChatServer.Items.Add("Server cài đặt thành công");

        }


      //Ngắt kết nối
        private static void CloseAllSockets()
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            serverSocket.Close();
        }


        //Chấp nhận kết nối
        private  void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            clientSockets.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
           
            serverSocket.BeginAccept(AcceptCallback, null);
        }


        //Nhận tin nhắn
        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                current.Close();
                clientSockets.Remove(current);
                return;
            }
            
            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = (string)GomManh(recBuf);
            //Client kết nối hiển thị danh sách online
            if (text.Contains("@@"))
            {
                String message = text.Substring(0, 5) + current.RemoteEndPoint;
                lb_ClientOnline.Items.Add(message);
                lvChatServer.Items.Add(text);
            }
            //Client ngắt kết nối
            else if (text.Contains("$$"))
            {
                lb_ClientOnline.Items.Remove(text.Substring(0, 5) + current.RemoteEndPoint);
                lvChatServer.Items.Add(text);
                 current.Close();
            }
            //Chat client
            else if (text.Contains("ChatClient"))
            {
                String getMyMessage = text.Remove(0, 42);
                //tìm client  trong danh sách online

                for (int i = 0; i < clientSockets.Count; i++)
                {
                    
                    for (int ip = 0; ip < lb_ClientOnline.Items.Count; ip++)
                    {
                        if (lb_ClientOnline.Items[ip].ToString().Contains(text.Remove(0, 26).Substring(0, 5)))
                        {
                            if (clientSockets[i].RemoteEndPoint.ToString() == lb_ClientOnline.Items[ip].ToString().Remove(0, 5))
                            {
                                clientSockets[i].Send(PhanManh(text));
                            }
                        }
                    }

                }
                current.Send(PhanManh("MyCchatClient" + getMyMessage));

            }
            //Chat room
            else if(text.Contains("CchatRooomm"))
            {
                String NameRoom = text.Remove(0, 27).Substring(0, 7);
                DataTable Data = BllServer.Instance.Server.FindNameRoom(NameRoom);
                //Tìm những client có trong nhóm mà đang online để gửi tin nhắn
                
                for (int i = 0; i < clientSockets.Count; i++)
                {
                    int trunggian = 0;
                    for (int ip = 0; ip < lb_ClientOnline.Items.Count; ip++)
                    {
                        foreach (DataRow dtRow in Data.Rows)
                        {
                            String nameClient = dtRow.ItemArray[1].ToString().Remove(5, 45);
                            if(lb_ClientOnline.Items[ip].ToString().Contains(nameClient)&&trunggian==0)
                            {
                                trunggian++;
                                clientSockets[i].Send(PhanManh(text));
                            }
                        }
                    }

                }
            }
            else
            {
                lvChatServer.Items.Add(text);
                //  current.Send(PhanManh("Tôi là " + text));
                chatAll(text);
            }
            try
            {
                current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);

            }
            catch (Exception)
            {

                current.Close();
                
                
            }
           }


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
        //Hiển thị danh sách client online phía server
        void DisplayClientOnline()
        {
           
            Task.Run(async () => {
                for (;;)
                {
                    await Task.Delay(5000);
                    lbTotalClient.Text = "Tổng số client online là: " +lb_ClientOnline.Items.Count;
                    sendListClientOnline();
                    lb_Total_Client.Text = "Tổng số client là: " + BLL.BllServer.Instance.Server.DisplayTotalClient();
                }
            });

        }
        ////Gửi danh sách đã kết nối qua phía client
        void sendListClientOnline()
        {  for(int client=0;client<clientSockets.Count;client++)
            {
                for (int i = 0; i < lb_ClientOnline.Items.Count; i++)
                {
                    clientSockets[client].Send(PhanManh("@@"+lb_ClientOnline.Items[i].ToString()  ));
                }
            } 
            
        }
        //Chat all
        void chatAll(String mess)
        {
           
            for(int i=0;i<clientSockets.Count;i++)
            {
                clientSockets[i].Send(PhanManh(mess));
            }
        }

    }
}
