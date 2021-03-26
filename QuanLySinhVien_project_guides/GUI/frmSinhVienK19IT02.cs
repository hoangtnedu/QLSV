using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_project_guides.GUI
{
    public partial class frmSinhVienK19IT02 : Form
    {
        public frmSinhVienK19IT02()
        {
            InitializeComponent();
        }

        private void frmSinhVienK19IT02_Load(object sender, EventArgs e)
        {
            BUS.ClsReportSinhVien report = new BUS.ClsReportSinhVien();
            report.BaoCaoAllSV(crvSinhvienK19It02, @"..\..\CrystalReport\crSinhVienK19IT02.rpt");
        }
    }
}
