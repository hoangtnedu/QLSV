namespace QuanLySinhVien_project_guides.GUI
{
    partial class frmSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTTSV = new System.Windows.Forms.DataGridView();
            this.btnShowTT = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddbyClass = new System.Windows.Forms.Button();
            this.btnUpdatebyClass = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cachedcRSinhVien1 = new QuanLySinhVien_project_guides.CrystalReport.CachedcRSinhVien();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN";
            // 
            // dgvTTSV
            // 
            this.dgvTTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTSV.Location = new System.Drawing.Point(12, 131);
            this.dgvTTSV.Name = "dgvTTSV";
            this.dgvTTSV.Size = new System.Drawing.Size(743, 180);
            this.dgvTTSV.TabIndex = 7;
            // 
            // btnShowTT
            // 
            this.btnShowTT.BackColor = System.Drawing.SystemColors.Info;
            this.btnShowTT.Location = new System.Drawing.Point(12, 317);
            this.btnShowTT.Name = "btnShowTT";
            this.btnShowTT.Size = new System.Drawing.Size(75, 23);
            this.btnShowTT.TabIndex = 8;
            this.btnShowTT.Text = "Show TT";
            this.btnShowTT.UseVisualStyleBackColor = false;
            this.btnShowTT.Click += new System.EventHandler(this.btnShowTT_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaSV.Location = new System.Drawing.Point(94, 47);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(115, 20);
            this.txtMaSV.TabIndex = 2;
            // 
            // txtTenSV
            // 
            this.txtTenSV.BackColor = System.Drawing.SystemColors.Info;
            this.txtTenSV.Location = new System.Drawing.Point(78, 86);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(131, 20);
            this.txtTenSV.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Info;
            this.txtSDT.Location = new System.Drawing.Point(282, 47);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(127, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BackColor = System.Drawing.SystemColors.Info;
            this.txtQueQuan.Location = new System.Drawing.Point(282, 90);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(127, 20);
            this.txtQueQuan.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.SystemColors.Info;
            this.txtGhiChu.Location = new System.Drawing.Point(486, 74);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(201, 45);
            this.txtGhiChu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên SV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SDT: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Location = new System.Drawing.Point(94, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(272, 317);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddbyClass
            // 
            this.btnAddbyClass.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddbyClass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAddbyClass.Location = new System.Drawing.Point(175, 317);
            this.btnAddbyClass.Name = "btnAddbyClass";
            this.btnAddbyClass.Size = new System.Drawing.Size(91, 23);
            this.btnAddbyClass.TabIndex = 11;
            this.btnAddbyClass.Text = "Add by Class";
            this.btnAddbyClass.UseVisualStyleBackColor = false;
            this.btnAddbyClass.Click += new System.EventHandler(this.btnAddbyClass_Click);
            // 
            // btnUpdatebyClass
            // 
            this.btnUpdatebyClass.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdatebyClass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdatebyClass.Location = new System.Drawing.Point(354, 318);
            this.btnUpdatebyClass.Name = "btnUpdatebyClass";
            this.btnUpdatebyClass.Size = new System.Drawing.Size(116, 23);
            this.btnUpdatebyClass.TabIndex = 12;
            this.btnUpdatebyClass.Text = "Update by Class";
            this.btnUpdatebyClass.UseVisualStyleBackColor = false;
            this.btnUpdatebyClass.Click += new System.EventHandler(this.btnUpdatebyClass_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(487, 46);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày sinh: ";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 349);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnUpdatebyClass);
            this.Controls.Add(this.btnAddbyClass);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.btnShowTT);
            this.Controls.Add(this.dgvTTSV);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVien";
            this.Text = "Quản lý thông tin sinh viên ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTTSV;
        private System.Windows.Forms.Button btnShowTT;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddbyClass;
        private System.Windows.Forms.Button btnUpdatebyClass;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label7;
        private CrystalReport.CachedcRSinhVien cachedcRSinhVien1;
    }
}