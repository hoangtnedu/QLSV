namespace QuanLySinhVien_project_guides.GUI
{
    partial class frmConnectbyWindows
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
            this.btnKetnoibangquyenwindows = new System.Windows.Forms.Button();
            this.lblTB = new System.Windows.Forms.Label();
            this.btnKetNoiThongQuaDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKetnoibangquyenwindows
            // 
            this.btnKetnoibangquyenwindows.Location = new System.Drawing.Point(56, 35);
            this.btnKetnoibangquyenwindows.Name = "btnKetnoibangquyenwindows";
            this.btnKetnoibangquyenwindows.Size = new System.Drawing.Size(171, 23);
            this.btnKetnoibangquyenwindows.TabIndex = 0;
            this.btnKetnoibangquyenwindows.Text = "Ket noi bang quyen windows";
            this.btnKetnoibangquyenwindows.UseVisualStyleBackColor = true;
            this.btnKetnoibangquyenwindows.Click += new System.EventHandler(this.btnKetnoibangquyenwindows_Click);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Location = new System.Drawing.Point(53, 9);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(35, 13);
            this.lblTB.TabIndex = 1;
            this.lblTB.Text = "label1";
            // 
            // btnKetNoiThongQuaDangNhap
            // 
            this.btnKetNoiThongQuaDangNhap.BackColor = System.Drawing.SystemColors.Info;
            this.btnKetNoiThongQuaDangNhap.Location = new System.Drawing.Point(56, 76);
            this.btnKetNoiThongQuaDangNhap.Name = "btnKetNoiThongQuaDangNhap";
            this.btnKetNoiThongQuaDangNhap.Size = new System.Drawing.Size(171, 23);
            this.btnKetNoiThongQuaDangNhap.TabIndex = 2;
            this.btnKetNoiThongQuaDangNhap.Text = "Kết nối thông qua đăng nhập";
            this.btnKetNoiThongQuaDangNhap.UseVisualStyleBackColor = false;
            this.btnKetNoiThongQuaDangNhap.Click += new System.EventHandler(this.btnKetNoiThongQuaDangNhap_Click);
            // 
            // frmConnectbyWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 122);
            this.Controls.Add(this.btnKetNoiThongQuaDangNhap);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.btnKetnoibangquyenwindows);
            this.Name = "frmConnectbyWindows";
            this.Text = "Kết nối cơ sở dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKetnoibangquyenwindows;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Button btnKetNoiThongQuaDangNhap;
    }
}