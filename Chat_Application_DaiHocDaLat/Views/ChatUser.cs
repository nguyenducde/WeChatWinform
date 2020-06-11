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
    public partial class frm_ChatUser : MaterialForm
    {
      
        public  void getChatUser(String mess)
        {
            if (!String.IsNullOrEmpty(mess))
            {
                //Nếu người gửi bằng người nhắn tin thì hiện tin nhắn
                //if (mess.Substring(0, 5) == Text.Remove(0, 32))
                //{
                //    lv_ChatUserClient.Items.Add(mess.Remove(7, 36));
                //}
                lv_ChatUserClient.Items.Add(mess.Remove(7, 36));

            }
          
        }
        public frm_ChatUser()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan500, Primary.DeepOrange800, Accent.Cyan700, TextShade.BLACK);
            CheckForIllegalCrossThreadCalls = false;
        }
       
        private void btn_Chat_User_Click(object sender, EventArgs e)
        {
            if(txt_Chat_User.Text!="")
            {
                String locChuoi = Text.Remove(0, 13).Substring(0, 5) + " :" + Text.Remove(5, 13);
                MainClient.ClientSocket.Send(PhanManh(locChuoi + " ChatClient " + txt_Chat_User.Text));
                txt_Chat_User.Text = "";

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
        //Hiển thị thông tin người dùng
        public void DisplayUser(String myUser, String FriendUser, string mess)
        {
            Text = "Người dùng : " + myUser + " nhắn tin với " + FriendUser.Substring(0, 5);
           
        }
        //Lấy tin nhắn lúc mình gửi
        public void GetMyChatMess(String mess)
        {
            if(!String.IsNullOrEmpty(mess))
            {
                lv_ChatUserClient.Items.Add(mess);
            }
            
        }

       
    }
}
