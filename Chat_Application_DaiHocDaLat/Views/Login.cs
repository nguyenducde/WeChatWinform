using Chat_Application_DaiHocDaLat.BLL;
using DevExpress.XtraEditors;
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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        Register frmDK = new Register();
        public Login()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan500, Primary.DeepOrange800, Accent.Cyan700, TextShade.BLACK);
        }

        private void lbDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDK.Show();
        }

        private void mtrButtonPass_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Length + txt_PassWord.Text.Length == 0)
            {
                XtraMessageBox.Show("Vui lòng nhập lại tài khoản mật khẩu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BllClient.Instance.Client.Login(txt_UserName.Text, txt_PassWord.Text))
                {
                   // BllClient.Instance.Client.setStatusOnline(txt_UserName.Text);
                   
                    this.Hide();
                    Loading frmload = new Loading(txt_UserName.Text);
                    frmload.Show();
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng nhập lại tài khoản mật khẩu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void mtrSingleTextUS_Click(object sender, EventArgs e)
        {

        }
    }
}
