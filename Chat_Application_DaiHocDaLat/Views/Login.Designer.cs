namespace Chat_Application_DaiHocDaLat.Views
{
    partial class Login
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
            this.lbDK = new System.Windows.Forms.LinkLabel();
            this.mtrButtonPass = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_PassWord = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_UserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDK
            // 
            this.lbDK.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbDK.AutoSize = true;
            this.lbDK.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDK.LinkColor = System.Drawing.SystemColors.GrayText;
            this.lbDK.Location = new System.Drawing.Point(112, 567);
            this.lbDK.Name = "lbDK";
            this.lbDK.Size = new System.Drawing.Size(153, 23);
            this.lbDK.TabIndex = 12;
            this.lbDK.TabStop = true;
            this.lbDK.Text = "Create to account";
            this.lbDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbDK_LinkClicked);
            // 
            // mtrButtonPass
            // 
            this.mtrButtonPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtrButtonPass.Depth = 0;
            this.mtrButtonPass.Location = new System.Drawing.Point(133, 497);
            this.mtrButtonPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtrButtonPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrButtonPass.Name = "mtrButtonPass";
            this.mtrButtonPass.Primary = true;
            this.mtrButtonPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtrButtonPass.Size = new System.Drawing.Size(123, 38);
            this.mtrButtonPass.TabIndex = 11;
            this.mtrButtonPass.Text = "Login";
            this.mtrButtonPass.UseVisualStyleBackColor = true;
            this.mtrButtonPass.Click += new System.EventHandler(this.mtrButtonPass_Click);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Depth = 0;
            this.txt_PassWord.Hint = "Password";
            this.txt_PassWord.Location = new System.Drawing.Point(85, 441);
            this.txt_PassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PassWord.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '\0';
            this.txt_PassWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_PassWord.SelectedText = "";
            this.txt_PassWord.SelectionLength = 0;
            this.txt_PassWord.SelectionStart = 0;
            this.txt_PassWord.Size = new System.Drawing.Size(227, 28);
            this.txt_PassWord.TabIndex = 10;
            this.txt_PassWord.TabStop = false;
            this.txt_PassWord.UseSystemPasswordChar = true;
            this.txt_PassWord.Click += new System.EventHandler(this.mtrSingleTextUS_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Depth = 0;
            this.txt_UserName.Hint = "Username";
            this.txt_UserName.Location = new System.Drawing.Point(85, 391);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PasswordChar = '\0';
            this.txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_UserName.SelectedText = "";
            this.txt_UserName.SelectionLength = 0;
            this.txt_UserName.SelectionStart = 0;
            this.txt_UserName.Size = new System.Drawing.Size(227, 28);
            this.txt_UserName.TabIndex = 9;
            this.txt_UserName.TabStop = false;
            this.txt_UserName.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(17, 554);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(352, 1);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chat_Application_DaiHocDaLat.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.mtrButtonPass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 608);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lbDK);
            this.Controls.Add(this.mtrButtonPass);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbDK;
        private MaterialSkin.Controls.MaterialRaisedButton mtrButtonPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_PassWord;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}