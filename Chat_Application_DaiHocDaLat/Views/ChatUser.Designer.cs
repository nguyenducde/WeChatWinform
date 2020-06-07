namespace Chat_Application_DaiHocDaLat.Views
{
    partial class frm_ChatUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Chat_User = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_Chat_User = new System.Windows.Forms.TextBox();
            this.lv_ChatUserClient = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv_ChatUserClient);
            this.panel1.Controls.Add(this.btn_Chat_User);
            this.panel1.Controls.Add(this.txt_Chat_User);
            this.panel1.Location = new System.Drawing.Point(-3, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 338);
            this.panel1.TabIndex = 0;
            // 
            // btn_Chat_User
            // 
            this.btn_Chat_User.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Chat_User.Depth = 0;
            this.btn_Chat_User.Location = new System.Drawing.Point(383, 281);
            this.btn_Chat_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Chat_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Chat_User.Name = "btn_Chat_User";
            this.btn_Chat_User.Primary = true;
            this.btn_Chat_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Chat_User.Size = new System.Drawing.Size(125, 39);
            this.btn_Chat_User.TabIndex = 45;
            this.btn_Chat_User.Text = "Send";
            this.btn_Chat_User.UseVisualStyleBackColor = true;
            this.btn_Chat_User.Click += new System.EventHandler(this.btn_Chat_User_Click);
            // 
            // txt_Chat_User
            // 
            this.txt_Chat_User.Location = new System.Drawing.Point(17, 281);
            this.txt_Chat_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Chat_User.Multiline = true;
            this.txt_Chat_User.Name = "txt_Chat_User";
            this.txt_Chat_User.Size = new System.Drawing.Size(357, 38);
            this.txt_Chat_User.TabIndex = 7;
            // 
            // lv_ChatUserClient
            // 
            this.lv_ChatUserClient.FormattingEnabled = true;
            this.lv_ChatUserClient.ItemHeight = 16;
            this.lv_ChatUserClient.Location = new System.Drawing.Point(17, 7);
            this.lv_ChatUserClient.Name = "lv_ChatUserClient";
            this.lv_ChatUserClient.Size = new System.Drawing.Size(491, 260);
            this.lv_ChatUserClient.TabIndex = 46;
            // 
            // frm_ChatUser
            // 
            this.AcceptButton = this.btn_Chat_User;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 415);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ChatUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Chat_User;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Chat_User;
        private System.Windows.Forms.ListBox lv_ChatUserClient;
    }
}