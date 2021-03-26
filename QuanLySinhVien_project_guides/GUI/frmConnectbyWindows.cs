using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLySinhVien_project_guides.GUI
{
    public partial class frmConnectbyWindows : Form
    {
        public frmConnectbyWindows()
        {
            InitializeComponent();
        }

        private void btnKetnoibangquyenwindows_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString =
                @"Data Source=DESKTOP-H68FGFI\SQLSERVER;Initial Catalog=QLSV;
Integrated Security=True";
            try
            {
                Conn.Open();
                lblTB.Text = "Ket noi bang windows thanh cong!";
            }
            catch (Exception ex)
            {
                lblTB.Text = "Ket noi that bai" + ex.ToString();
            }
        }

        private void btnKetNoiThongQuaDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString =
                @"Data Source=DESKTOP-H68FGFI\SQLSERVER;Initial Catalog=QLSV;User ID=hoangtn1204;Password =123";
            try
            {
                Conn.Open();
                lblTB.Text = "Kết nối thông qua tài khoản hoangtn1204, mật khẩu 123 thành công!";
            }
            catch (Exception ex)
            {
                lblTB.Text = "Kết nối thất bại!!!" + ex.ToString();
            }
        }
    }
}
