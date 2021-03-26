using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.BUS
{
    class ClsReportSinhVien
    {
        //SqlConnection conn = new SqlConnection();
        public void BaoCaoAllSV(CrystalReportViewer reporViewer,string CrystalReportFileName)
        {
            
            ReportDocument Report = new ReportDocument();
            Report.Load(CrystalReportFileName);
            Report.SetDatabaseLogon( "hoangtn1204", "123", @"DESKTOP-H68FGFI\SQLSERVER", "QLSV");
            reporViewer.ReportSource = Report;
        }
    }
}
