
namespace QuanLySinhVien_project_guides.GUI
{
    partial class frmSinhVienK19IT02
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
            this.crvSinhvienK19It02 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cachedcRSinhVien1 = new QuanLySinhVien_project_guides.CrystalReport.CachedcRSinhVien();
            this.SuspendLayout();
            // 
            // crvSinhvienK19It02
            // 
            this.crvSinhvienK19It02.ActiveViewIndex = -1;
            this.crvSinhvienK19It02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSinhvienK19It02.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSinhvienK19It02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSinhvienK19It02.Location = new System.Drawing.Point(0, 0);
            this.crvSinhvienK19It02.Name = "crvSinhvienK19It02";
            this.crvSinhvienK19It02.Size = new System.Drawing.Size(486, 273);
            this.crvSinhvienK19It02.TabIndex = 0;
            // 
            // frmSinhVienK19IT02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 273);
            this.Controls.Add(this.crvSinhvienK19It02);
            this.Name = "frmSinhVienK19IT02";
            this.Text = "Báo cáo sinh viên đang học K19IT02";
            this.Load += new System.EventHandler(this.frmSinhVienK19IT02_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSinhvienK19It02;
        private CrystalReport.CachedcRSinhVien cachedcRSinhVien1;
    }
}