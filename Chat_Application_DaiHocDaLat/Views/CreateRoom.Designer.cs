namespace Chat_Application_DaiHocDaLat.Views
{
    partial class FrmCreateRoom
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
            this.txt_Name_Room = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoNhom = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txt_Name_Room
            // 
            this.txt_Name_Room.Location = new System.Drawing.Point(119, 78);
            this.txt_Name_Room.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Name_Room.Name = "txt_Name_Room";
            this.txt_Name_Room.Size = new System.Drawing.Size(203, 20);
            this.txt_Name_Room.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Robika", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Name";
            // 
            // btnTaoNhom
            // 
            this.btnTaoNhom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoNhom.Depth = 0;
            this.btnTaoNhom.Location = new System.Drawing.Point(119, 114);
            this.btnTaoNhom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTaoNhom.Name = "btnTaoNhom";
            this.btnTaoNhom.Primary = true;
            this.btnTaoNhom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTaoNhom.Size = new System.Drawing.Size(94, 32);
            this.btnTaoNhom.TabIndex = 46;
            this.btnTaoNhom.Text = "Create";
            this.btnTaoNhom.UseVisualStyleBackColor = true;
            this.btnTaoNhom.Click += new System.EventHandler(this.btnTaoNhom_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(227, 114);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialRaisedButton1.Size = new System.Drawing.Size(94, 32);
            this.materialRaisedButton1.TabIndex = 47;
            this.materialRaisedButton1.Text = "Back";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // FrmCreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 149);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnTaoNhom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Name_Room);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCreateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRoom";
            this.Load += new System.EventHandler(this.FrmCreateRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name_Room;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnTaoNhom;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}