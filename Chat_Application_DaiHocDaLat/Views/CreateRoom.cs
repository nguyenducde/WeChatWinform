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
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application_DaiHocDaLat.Views
{
    public partial class FrmCreateRoom : MaterialForm
    {
        public FrmCreateRoom()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan500, Primary.DeepOrange800, Accent.Cyan700, TextShade.BLACK);
        }



        private void FrmCreateRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoNhom_Click(object sender, EventArgs e)
        {
            String nameRoom = txt_Name_Room.Text;
            if (nameRoom.Length == 7)
            {
               
                    BllClient.Instance.Client.insertRoom(nameRoom);
                    MainClient.ClientSocket.Send(PhanManh("TtaoPhong"+nameRoom));
                    txt_Name_Room.Text = "";
                    MessageBox.Show("Tạo nhóm " + nameRoom + " thành công");
                    this.Close();
                
              
            }
            else
            {
                MessageBox.Show("Vui lòng tạo nhóm có 7 kí tự ");
            }
               
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
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
    }
}
