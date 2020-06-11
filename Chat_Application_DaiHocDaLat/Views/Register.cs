using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application_DaiHocDaLat.Views
{
    public partial class Register : MaterialSkin.Controls.MaterialForm
    {
   
        public Register()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan500, Primary.DeepOrange800, Accent.Cyan700, TextShade.BLACK);
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void mtrButtonPass_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string pass = txt_pass.Text;
            string passConfirm = txt_pass_confirm.Text;
            if(pass!=passConfirm)
            {
                MessageBox.Show("Mật khẩu không trùng nhau");
            }
            else if (name.Length==5)
            {
                if(BLL.BllClient.Instance.Client.checkUser(name))
                {
                    MessageBox.Show("Tên này khoản này đã tồn tại");
                }
                else
                {
                    BLL.BllClient.Instance.Client.insertUser(name, pass);
                    MessageBox.Show("Tạo tài khoản thành công");
                   
                }
            }
            else
            {
                MessageBox.Show("Vui lòng tạo tên tài khoản 6 kí tự");
            }

        }

        private void mtrSingleTextUS_Click(object sender, EventArgs e)
        {
            

        }
    }
}
