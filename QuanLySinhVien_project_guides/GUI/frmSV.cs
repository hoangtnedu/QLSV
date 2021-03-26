using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_project_guides.GUI
{
    public partial class frmSV : Form
    {
        public frmSV()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection();
        private void btnXem_Click(object sender, EventArgs e)
        {
            Conn.ConnectionString =
           @"Data Source=DESKTOP-H68FGFI\SQLSERVER;Initial Catalog=QLSV;Integrated Security=True";
            try
            {
                //if (Conn.State== ConnectionState.Closed) 
                Conn.Open();
                SqlCommand Comm = new SqlCommand();
                Comm.CommandText = "Select * from tblSinhVien";
                Comm.CommandType = CommandType.Text;
                Comm.Connection = Conn;
                Comm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(Comm);
                da.Fill(dt);
                dgvTTSV.DataSource = dt;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnThemcuthe_Click(object sender, EventArgs e)
        {
            Conn.ConnectionString =
 @"Data Source=DESKTOP-H68FGFI\SQLSERVER;Initial Catalog=QLSV;Integrated Security=True";
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
                SqlCommand Comm = new SqlCommand();
                Comm.CommandText = "Insert into tblSinhVien(MaSV,TenSV,SDT,QueQuan,GhiChu)" +
                    "values('20011930077',N'Phan Thị Mai Hoa','0933434356',N'Vinh Phu','Ko')";
                Comm.CommandType = CommandType.Text;
                Comm.Connection = Conn;
                Comm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(Comm);
                da.Fill(dt);
                dgvTTSV.DataSource = dt;
            }
            catch (Exception ex)
            {
            }
        }
    }
}

