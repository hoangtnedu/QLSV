
namespace QuanLySinhVien_project_guides.GUI
{
    partial class frmReportSV
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
            this.rpvSinhvienAlll = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpvSinhvienAlll
            // 
            this.rpvSinhvienAlll.ActiveViewIndex = -1;
            this.rpvSinhvienAlll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvSinhvienAlll.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvSinhvienAlll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvSinhvienAlll.Location = new System.Drawing.Point(0, 0);
            this.rpvSinhvienAlll.Name = "rpvSinhvienAlll";
            this.rpvSinhvienAlll.Size = new System.Drawing.Size(581, 450);
            this.rpvSinhvienAlll.TabIndex = 0;
            // 
            // frmReportSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.rpvSinhvienAlll);
            this.Name = "frmReportSV";
            this.Text = "Báo cáo toàn bộ sinh viên đang học";
            this.Load += new System.EventHandler(this.frmReportSV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvSinhvienAlll;
    }
}