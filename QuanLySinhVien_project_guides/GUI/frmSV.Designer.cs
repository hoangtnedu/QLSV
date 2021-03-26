namespace QuanLySinhVien_project_guides.GUI
{
    partial class frmSV
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
            this.dgvTTSV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThemcuthe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTTSV
            // 
            this.dgvTTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTSV.Location = new System.Drawing.Point(4, 158);
            this.dgvTTSV.Name = "dgvTTSV";
            this.dgvTTSV.Size = new System.Drawing.Size(570, 185);
            this.dgvTTSV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(157, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.Info;
            this.btnXem.Location = new System.Drawing.Point(12, 348);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThemcuthe
            // 
            this.btnThemcuthe.BackColor = System.Drawing.SystemColors.Info;
            this.btnThemcuthe.Location = new System.Drawing.Point(93, 348);
            this.btnThemcuthe.Name = "btnThemcuthe";
            this.btnThemcuthe.Size = new System.Drawing.Size(97, 23);
            this.btnThemcuthe.TabIndex = 3;
            this.btnThemcuthe.Text = "Thêm GT cụ thể.";
            this.btnThemcuthe.UseVisualStyleBackColor = false;
            this.btnThemcuthe.Click += new System.EventHandler(this.btnThemcuthe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quê quán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SDT: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã SV:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.SystemColors.Info;
            this.txtGhiChu.Location = new System.Drawing.Point(471, 74);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 59);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BackColor = System.Drawing.SystemColors.Info;
            this.txtQueQuan.Location = new System.Drawing.Point(267, 117);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(127, 20);
            this.txtQueQuan.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Info;
            this.txtSDT.Location = new System.Drawing.Point(267, 74);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(127, 20);
            this.txtSDT.TabIndex = 7;
            // 
            // txtTenSV
            // 
            this.txtTenSV.BackColor = System.Drawing.SystemColors.Info;
            this.txtTenSV.Location = new System.Drawing.Point(63, 113);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(131, 20);
            this.txtTenSV.TabIndex = 8;
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaSV.Location = new System.Drawing.Point(79, 74);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(115, 20);
            this.txtMaSV.TabIndex = 9;
            // 
            // frmSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 378);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnThemcuthe);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTTSV);
            this.Name = "frmSV";
            this.Text = "Thông tin sinh viên - HD K19IT01";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTTSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThemcuthe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
    }
}