namespace QuanLySinhVien_project_guides
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtNốiCSDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ketNoiBangQuyenWinodwsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tTSVKetNoiTructiepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoSinhViênĐangHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCSinhVieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.tTSVToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kếtNốiCSDLToolStripMenuItem,
            this.ketNoiBangQuyenWinodwsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // kếtNốiCSDLToolStripMenuItem
            // 
            this.kếtNốiCSDLToolStripMenuItem.Name = "kếtNốiCSDLToolStripMenuItem";
            this.kếtNốiCSDLToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.kếtNốiCSDLToolStripMenuItem.Text = "Kết nối CSDL";
            this.kếtNốiCSDLToolStripMenuItem.Click += new System.EventHandler(this.kếtNốiCSDLToolStripMenuItem_Click);
            // 
            // ketNoiBangQuyenWinodwsToolStripMenuItem
            // 
            this.ketNoiBangQuyenWinodwsToolStripMenuItem.Name = "ketNoiBangQuyenWinodwsToolStripMenuItem";
            this.ketNoiBangQuyenWinodwsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ketNoiBangQuyenWinodwsToolStripMenuItem.Text = "Ket noi bang quyen windows";
            this.ketNoiBangQuyenWinodwsToolStripMenuItem.Click += new System.EventHandler(this.ketNoiBangQuyenWinodwsToolStripMenuItem_Click);
            // 
            // tTSVToolStripMenuItem
            // 
            this.tTSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tTSVToolStripMenuItem1,
            this.tTSVKetNoiTructiepToolStripMenuItem});
            this.tTSVToolStripMenuItem.Name = "tTSVToolStripMenuItem";
            this.tTSVToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.tTSVToolStripMenuItem.Text = "Sinh viên";
            // 
            // tTSVToolStripMenuItem1
            // 
            this.tTSVToolStripMenuItem1.Name = "tTSVToolStripMenuItem1";
            this.tTSVToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.tTSVToolStripMenuItem1.Text = "TTSV";
            this.tTSVToolStripMenuItem1.Click += new System.EventHandler(this.tTSVToolStripMenuItem1_Click);
            // 
            // tTSVKetNoiTructiepToolStripMenuItem
            // 
            this.tTSVKetNoiTructiepToolStripMenuItem.Name = "tTSVKetNoiTructiepToolStripMenuItem";
            this.tTSVKetNoiTructiepToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tTSVKetNoiTructiepToolStripMenuItem.Text = "TTSV-KetNoiTructiep";
            this.tTSVKetNoiTructiepToolStripMenuItem.Click += new System.EventHandler(this.tTSVKetNoiTructiepToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoSinhViênĐangHọcToolStripMenuItem,
            this.bCSinhVieToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // báoCáoSinhViênĐangHọcToolStripMenuItem
            // 
            this.báoCáoSinhViênĐangHọcToolStripMenuItem.Name = "báoCáoSinhViênĐangHọcToolStripMenuItem";
            this.báoCáoSinhViênĐangHọcToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.báoCáoSinhViênĐangHọcToolStripMenuItem.Text = "Báo cáo sinh viên đang học";
            this.báoCáoSinhViênĐangHọcToolStripMenuItem.Click += new System.EventHandler(this.báoCáoSinhViênĐangHọcToolStripMenuItem_Click);
            // 
            // bCSinhVieToolStripMenuItem
            // 
            this.bCSinhVieToolStripMenuItem.Name = "bCSinhVieToolStripMenuItem";
            this.bCSinhVieToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.bCSinhVieToolStripMenuItem.Text = "Báo cáo sinh viên đang học K19IT02";
            this.bCSinhVieToolStripMenuItem.Click += new System.EventHandler(this.bCSinhVieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 241);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtNốiCSDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ketNoiBangQuyenWinodwsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tTSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tTSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tTSVKetNoiTructiepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoSinhViênĐangHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bCSinhVieToolStripMenuItem;
    }
}

