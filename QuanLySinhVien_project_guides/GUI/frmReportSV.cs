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
    public partial class frmReportSV : Form
    {
        public frmReportSV()
        {
            InitializeComponent();

        }

        private void frmReportSV_Load(object sender, EventArgs e)
        {
            BUS.ClsReportSinhVien report = new BUS.ClsReportSinhVien();
            report.BaoCaoAllSV(rpvSinhvienAlll, @"..\..\CrystalReport\cRSinhVien.rpt");
        }
    }
}
