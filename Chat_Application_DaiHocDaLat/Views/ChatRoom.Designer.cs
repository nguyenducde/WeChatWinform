namespace Chat_Application_DaiHocDaLat.Views
{
    partial class ChatRoom
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
            this.btn_Chat_Room = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_Chat_Room = new System.Windows.Forms.TextBox();
            this.lv_ChatRoom = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv_ChatRoom);
            this.panel1.Controls.Add(this.btn_Chat_Room);
            this.panel1.Controls.Add(this.txt_Chat_Room);
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 363);
            this.panel1.TabIndex = 0;
            // 
            // btn_Chat_Room
            // 
            this.btn_Chat_Room.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Chat_Room.Depth = 0;
            this.btn_Chat_Room.Location = new System.Drawing.Point(343, 309);
            this.btn_Chat_Room.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Chat_Room.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Chat_Room.Name = "btn_Chat_Room";
            this.btn_Chat_Room.Primary = true;
            this.btn_Chat_Room.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Chat_Room.Size = new System.Drawing.Size(143, 38);
            this.btn_Chat_Room.TabIndex = 48;
            this.btn_Chat_Room.Text = "Send";
            this.btn_Chat_Room.UseVisualStyleBackColor = true;
            this.btn_Chat_Room.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txt_Chat_Room
            // 
            this.txt_Chat_Room.Location = new System.Drawing.Point(23, 309);
            this.txt_Chat_Room.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Chat_Room.Multiline = true;
            this.txt_Chat_Room.Name = "txt_Chat_Room";
            this.txt_Chat_Room.Size = new System.Drawing.Size(312, 37);
            this.txt_Chat_Room.TabIndex = 47;
            // 
            // lv_ChatRoom
            // 
            this.lv_ChatRoom.FormattingEnabled = true;
            this.lv_ChatRoom.ItemHeight = 16;
            this.lv_ChatRoom.Location = new System.Drawing.Point(23, 6);
            this.lv_ChatRoom.Name = "lv_ChatRoom";
            this.lv_ChatRoom.Size = new System.Drawing.Size(463, 292);
            this.lv_ChatRoom.TabIndex = 49;
            // 
            // ChatRoom
            // 
            this.AcceptButton = this.btn_Chat_Room;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 442);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChatRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatRoom";
            this.Load += new System.EventHandler(this.ChatRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Chat_Room;
        private System.Windows.Forms.TextBox txt_Chat_Room;
        private System.Windows.Forms.ListBox lv_ChatRoom;
    }
}