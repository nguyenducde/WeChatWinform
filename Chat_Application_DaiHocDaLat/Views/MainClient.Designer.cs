namespace Chat_Application_DaiHocDaLat.Views
{
    partial class MainClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_ChatClient = new System.Windows.Forms.ListBox();
            this.bunifuosSwitch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.lbListRoom = new System.Windows.Forms.Label();
            this.lbCreate = new System.Windows.Forms.Label();
            this.lbDarkmode = new System.Windows.Forms.Label();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lb_List_Room = new System.Windows.Forms.ListBox();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lb_ClientOnline = new System.Windows.Forms.ListBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.lbOnl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv_ChatClient);
            this.panel1.Controls.Add(this.bunifuosSwitch);
            this.panel1.Controls.Add(this.lbListRoom);
            this.panel1.Controls.Add(this.lbCreate);
            this.panel1.Controls.Add(this.lbDarkmode);
            this.panel1.Controls.Add(this.materialDivider3);
            this.panel1.Controls.Add(this.materialDivider2);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.lb_List_Room);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.lb_ClientOnline);
            this.panel1.Controls.Add(this.txtChat);
            this.panel1.Controls.Add(this.lbOnl);
            this.panel1.Location = new System.Drawing.Point(-4, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 443);
            this.panel1.TabIndex = 0;
            // 
            // lv_ChatClient
            // 
            this.lv_ChatClient.FormattingEnabled = true;
            this.lv_ChatClient.ItemHeight = 16;
            this.lv_ChatClient.Location = new System.Drawing.Point(255, 16);
            this.lv_ChatClient.Name = "lv_ChatClient";
            this.lv_ChatClient.Size = new System.Drawing.Size(600, 340);
            this.lv_ChatClient.TabIndex = 53;
            // 
            // bunifuosSwitch
            // 
            this.bunifuosSwitch.BackColor = System.Drawing.Color.Transparent;
            this.bunifuosSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuosSwitch.BackgroundImage")));
            this.bunifuosSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuosSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuosSwitch.Location = new System.Drawing.Point(1072, 16);
            this.bunifuosSwitch.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuosSwitch.Name = "bunifuosSwitch";
            this.bunifuosSwitch.OffColor = System.Drawing.Color.Gray;
            this.bunifuosSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuosSwitch.Size = new System.Drawing.Size(35, 20);
            this.bunifuosSwitch.TabIndex = 52;
            this.bunifuosSwitch.Value = false;
            this.bunifuosSwitch.OnValueChange += new System.EventHandler(this.bunifuosSwitch_OnValueChange);
            // 
            // lbListRoom
            // 
            this.lbListRoom.AutoSize = true;
            this.lbListRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListRoom.Location = new System.Drawing.Point(912, 107);
            this.lbListRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListRoom.Name = "lbListRoom";
            this.lbListRoom.Size = new System.Drawing.Size(121, 29);
            this.lbListRoom.TabIndex = 51;
            this.lbListRoom.Text = "List Room";
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.Location = new System.Drawing.Point(912, 65);
            this.lbCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(203, 29);
            this.lbCreate.TabIndex = 50;
            this.lbCreate.Text = "CREATE GROUP";
            this.lbCreate.Click += new System.EventHandler(this.lbCreate_Click_1);
            // 
            // lbDarkmode
            // 
            this.lbDarkmode.AutoSize = true;
            this.lbDarkmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDarkmode.Location = new System.Drawing.Point(911, 16);
            this.lbDarkmode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDarkmode.Name = "lbDarkmode";
            this.lbDarkmode.Size = new System.Drawing.Size(139, 31);
            this.lbDarkmode.TabIndex = 49;
            this.lbDarkmode.Text = "Darkmode";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(884, 17);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(1, 410);
            this.materialDivider3.TabIndex = 48;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(221, 16);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1, 410);
            this.materialDivider2.TabIndex = 47;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.Color.White;
            this.materialDivider1.Location = new System.Drawing.Point(255, 368);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(600, 1);
            this.materialDivider1.TabIndex = 46;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lb_List_Room
            // 
            this.lb_List_Room.FormattingEnabled = true;
            this.lb_List_Room.ItemHeight = 16;
            this.lb_List_Room.Location = new System.Drawing.Point(917, 149);
            this.lb_List_Room.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_List_Room.Name = "lb_List_Room";
            this.lb_List_Room.Size = new System.Drawing.Size(200, 276);
            this.lb_List_Room.TabIndex = 45;
            this.lb_List_Room.SelectedIndexChanged += new System.EventHandler(this.lb_List_Room_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Depth = 0;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSend.Location = new System.Drawing.Point(712, 389);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSend.Size = new System.Drawing.Size(143, 38);
            this.btnSend.TabIndex = 44;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lb_ClientOnline
            // 
            this.lb_ClientOnline.FormattingEnabled = true;
            this.lb_ClientOnline.ItemHeight = 16;
            this.lb_ClientOnline.Location = new System.Drawing.Point(21, 50);
            this.lb_ClientOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_ClientOnline.Name = "lb_ClientOnline";
            this.lb_ClientOnline.Size = new System.Drawing.Size(172, 372);
            this.lb_ClientOnline.TabIndex = 43;
            this.lb_ClientOnline.SelectedIndexChanged += new System.EventHandler(this.lb_ClientOnline_SelectedIndexChanged);
            // 
            // txtChat
            // 
            this.txtChat.AccessibleName = "btn_Send";
            this.txtChat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtChat.Location = new System.Drawing.Point(255, 389);
            this.txtChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(449, 37);
            this.txtChat.TabIndex = 42;
            this.txtChat.UseSystemPasswordChar = true;
            // 
            // lbOnl
            // 
            this.lbOnl.AutoSize = true;
            this.lbOnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnl.Location = new System.Drawing.Point(19, 17);
            this.lbOnl.Name = "lbOnl";
            this.lbOnl.Size = new System.Drawing.Size(132, 31);
            this.lbOnl.TabIndex = 41;
            this.lbOnl.Text = "MEMBER";
            // 
            // MainClient
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 521);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainClient_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuosSwitch;
        private System.Windows.Forms.Label lbListRoom;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Label lbDarkmode;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ListBox lb_List_Room;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private System.Windows.Forms.ListBox lb_ClientOnline;
        private System.Windows.Forms.Label lbOnl;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.ListBox lv_ChatClient;
    }
}