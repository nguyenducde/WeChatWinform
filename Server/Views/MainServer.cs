using Server.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Views
{
    public partial class MainServer : Form
    {
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        
        public MainServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            DisplayClientOnline();


        }

        void Connect()
        {
          
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 9999));
           
            Thread listenClient = new Thread(() =>
            {
                
                    while (true)
                    {
                        serverSocket.Listen(0);
                        Socket client = serverSocket.Accept();
                        clientSockets.Add(client);
                        Thread listenReceive = new Thread(Receive);
                        listenReceive.IsBackground = true;
                        listenReceive.Start(client);
                    }
                
                
            });
            listenClient.IsBackground = true;
            listenClient.Start();
        }

        void Receive(object obj)
        {
            Socket current = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    current.Receive(data);
                    string text= (string)GomManh(data);
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
                       // lb_ClientOnline.Items.Remove((text.Substring(0, 5) + current.RemoteEndPoint).ToString());
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
                                if (lb_ClientOnline.Items[ip].Text.Contains(text.Remove(0, 26).Substring(0, 5)))
                                {
                                    if (clientSockets[i].RemoteEndPoint.ToString() == lb_ClientOnline.Items[ip].Text.Remove(0, 5))
                                    {
                                        clientSockets[i].Send(PhanManh(text));
                                    }
                                }
                            }

                        }
                        current.Send(PhanManh("MyCchatClient" + getMyMessage));

                    }
                    //Tao room
                    else if(text.Contains("TtaoPhong"))
                    {
                        String nameRoom = text.Remove(0, 9);
                        BllServer.Instance.Server.insertRoom(nameRoom);
                    }
                    //Chat room
                    else if (text.Contains("CchatRooomm"))
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
                                    if (lb_ClientOnline.Items[ip].Text.Contains(nameClient) && trunggian == 0)
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
                         current.Send(PhanManh("Tôi là " + text));
                        //chatAll(text);
                    }
                   

                }
            }
            catch
            {
               
                current.Close();
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (lb_ClientOnline.SelectedItems.Count > 0)
            {
                SendMessageFromServerToClient();
            }
            else
            {
                SendMessageFromServerToAllClient();
            }

            lvChatServer.Items.Add("Server: " + txtChat.Text);
            txtChat.Text = "";
        }
        private void SendMessageFromServerToClient()
        {
            int index = 0;
            for (int i = 0; i <= lb_ClientOnline.Items.Count - 1; i++)
            {
                if (lb_ClientOnline.Items[i].Selected == true)
                {
                    index = i;
                    break;
                }
            }
            clientSockets[index].Send(PhanManh("Server: " + txtChat.Text));

        }
        private void SendMessageFromServerToAllClient()
        {
            for (int i = 0; i < clientSockets.Count; i++)
            {
                clientSockets[i].Send(PhanManh("Server: " + txtChat.Text));

            }
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

        {
            for (int client = 0; client < clientSockets.Count; client++)
            {
                for (int i = 0; i < lb_ClientOnline.Items.Count; i++)
                {
                    clientSockets[client].Send(PhanManh("@@" + lb_ClientOnline.Items[i].Text));
                }
            }


        }
        //gửi danh sách phòng phía client
        void sendListRoom(String name)
        {
            for (int client = 0; client < clientSockets.Count; client++)
            {
                for (int i = 0; i < lb_ClientOnline.Items.Count; i++)
                {
                    clientSockets[client].Send(PhanManh("name?room"+name));
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

        private void MainServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < clientSockets.Count; i++)
            {
                clientSockets[i].Send(PhanManh("ServerClosed"));
            }
        }
    }
}
