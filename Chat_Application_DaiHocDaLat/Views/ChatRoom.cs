using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application_DaiHocDaLat.Views
{
    public partial class ChatRoom : MaterialForm
    {
        public ChatRoom()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan500, Primary.DeepOrange800, Accent.Cyan700, TextShade.BLACK);
        }
        public void DisplayUserChatRoom(String name,String nameRoom)
        {
            Text = name + " chat nhóm " + nameRoom;
        }

       

        public void getMessChatRoom(String mess)
        {
            String nameClientChat = mess.Remove(0, 11).Substring(0, 5);
            String message = mess.Remove(0, 75);
            lv_ChatRoom.Items.Add(nameClientChat+ ":"+message);
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txt_Chat_Room.Text != "")
            {
                MainClient.ClientSocket.Send(PhanManh("CchatRooomm" + Text + txt_Chat_Room.Text));
                txt_Chat_Room.Text = "";
            }
        }

        private void ChatRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
