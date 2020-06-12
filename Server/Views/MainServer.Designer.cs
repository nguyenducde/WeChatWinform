namespace Server.Views
{
    partial class MainServer
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
            this.txtChat = new System.Windows.Forms.TextBox();
            this.lbOnl = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbTotalClient = new System.Windows.Forms.Label();
            this.lb_Total_Client = new System.Windows.Forms.Label();
            this.lvChatServer = new System.Windows.Forms.ListBox();
            this.lb_ClientOnline = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(12, 362);
            this.txtChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(504, 61);
            this.txtChat.TabIndex = 17;
            // 
            // lbOnl
            // 
            this.lbOnl.AutoSize = true;
            this.lbOnl.Location = new System.Drawing.Point(524, 107);
            this.lbOnl.Name = "lbOnl";
            this.lbOnl.Size = new System.Drawing.Size(151, 17);
            this.lbOnl.TabIndex = 15;
            this.lbOnl.Text = "Danh sách người dùng";
            // 
            // btnSend
            // 
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSend.Location = new System.Drawing.Point(528, 360);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(166, 61);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send All";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbTotalClient
            // 
            this.lbTotalClient.AutoSize = true;
            this.lbTotalClient.Location = new System.Drawing.Point(548, 34);
            this.lbTotalClient.Name = "lbTotalClient";
            this.lbTotalClient.Size = new System.Drawing.Size(0, 17);
            this.lbTotalClient.TabIndex = 20;
            // 
            // lb_Total_Client
            // 
            this.lb_Total_Client.AutoSize = true;
            this.lb_Total_Client.Location = new System.Drawing.Point(553, 10);
            this.lb_Total_Client.Name = "lb_Total_Client";
            this.lb_Total_Client.Size = new System.Drawing.Size(0, 17);
            this.lb_Total_Client.TabIndex = 21;
            // 
            // lvChatServer
            // 
            this.lvChatServer.FormattingEnabled = true;
            this.lvChatServer.ItemHeight = 16;
            this.lvChatServer.Location = new System.Drawing.Point(12, 12);
            this.lvChatServer.Name = "lvChatServer";
            this.lvChatServer.Size = new System.Drawing.Size(504, 340);
            this.lvChatServer.TabIndex = 22;
            // 
            // lb_ClientOnline
            // 
            this.lb_ClientOnline.Location = new System.Drawing.Point(528, 127);
            this.lb_ClientOnline.Name = "lb_ClientOnline";
            this.lb_ClientOnline.Size = new System.Drawing.Size(174, 225);
            this.lb_ClientOnline.TabIndex = 23;
            this.lb_ClientOnline.UseCompatibleStateImageBehavior = false;
            this.lb_ClientOnline.View = System.Windows.Forms.View.List;
            // 
            // MainServer
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 433);
            this.Controls.Add(this.lb_ClientOnline);
            this.Controls.Add(this.lvChatServer);
            this.Controls.Add(this.lb_Total_Client);
            this.Controls.Add(this.lbTotalClient);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.lbOnl);
            this.Controls.Add(this.btnSend);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainServer";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainServer_FormClosed);
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label lbOnl;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbTotalClient;
        private System.Windows.Forms.Label lb_Total_Client;
        private System.Windows.Forms.ListBox lvChatServer;
        private System.Windows.Forms.ListView lb_ClientOnline;
    }
}