using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien_project_guides.GUI
{
    public partial class frmSinhVien : Form
    {
        /// <summary>
        /// Tạo thêm biến chứa chuỗi kết nối
        /// </summary>
        string StrConectionString;
        /// <summary>
        /// Phương thức khởi dựng mặc định với tham số là chuỗi kết nối
        /// </summary>
        /// <param name="_StrConnectionString">Chuỗi kết nối CSDL</param>
        public frmSinhVien(string _StrConnectionString)
        {
            InitializeComponent();
            StrConectionString = _StrConnectionString;
        }
        public frmSinhVien()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void btnShowTT_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dt.Clear();
            SqlConnection connection = new SqlConnection(StrConectionString);
            string text = "Insert into tblSinhvien(MaSV,TenSV,SDT,QueQuan,Ghichu)"
                + "values(@MaSV,@TenSV,@SDT,@QueQuan,@GhiChu)";
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand(text, connection);
            command.Parameters.AddWithValue("@MaSV", txtMaSV.Text.ToString().Trim());
            command.Parameters.AddWithValue("@TenSV", txtTenSV.Text.ToString().Trim());
            command.Parameters.AddWithValue("@SDT", txtSDT.Text.ToString().Trim());
            command.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.ToString().Trim());
            command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.ToString().Trim());
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Dispose();
            Display();
        }
        void Display()
        {
            dt.Clear();
            SqlConnection connection = new SqlConnection(StrConectionString);
            string text = "select * from tblSinhVien";
            SqlCommand command = new SqlCommand(text, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dgvTTSV.DataSource = dt;            
            DataBinding(dt);  
        }
        void DataBinding(DataTable dt)
        {
            txtMaSV.DataBindings.Add("Text", dt, "MaSV",true);
            string t = txtMaSV.Text;
            txtTenSV.DataBindings.Add("Text", dt, "TenSV",true);
            txtSDT.DataBindings.Add("Text", dt, "SDT",true);
            txtQueQuan.DataBindings.Add("Text",dt,"QueQuan",true);
            txtGhiChu.DataBindings.Add("Text", dt, "Ghichu",true);
            dtpNgaySinh.DataBindings.Add("Value", dt, "Ngaysinh", true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //dt.Clear();
            SqlConnection connection = new SqlConnection(StrConectionString);
            string strSqlCommand = "Update tblSinhVien " +
                "set TenSV ='" + txtTenSV.Text + "', SDT='" + txtSDT.Text + "'," +
                "QueQuan='" + txtQueQuan.Text + "',GhiChu='" + txtGhiChu.Text +
                "'where MaSV='" + txtMaSV.Text + "'";
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand(strSqlCommand, connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Dispose();
            #region capnhat
            //string text = "Update tblSinhVien" +
            //"set TenSV =@TenSV, SDT=@SDT,QueQuan=@QueQuan, GhiChu=@GhiChu";
            //command.Parameters.AddWithValue("@MaSV", txtMaSV.Text.ToString().Trim());

            //command.Parameters.AddWithValue("@TenSV", txtTenSV.Text.ToString().Trim());
            //command.Parameters.AddWithValue("@SDT", txtSDT.Text.ToString().Trim());
            //command.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.ToString().Trim());
            //command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.ToString().Trim());

            //Display();
            #endregion capnhat
        }

        private void btnAddbyClass_Click(object sender, EventArgs e)
        {
            DAL.clsSinhVien sv = new DAL.clsSinhVien
                (txtMaSV.Text, txtTenSV.Text
                , txtSDT.Text, txtQueQuan.Text, txtGhiChu.Text,dtpNgaySinh.Value);
            sv.Them1SV(StrConectionString);
        }

        private void btnUpdatebyClass_Click(object sender, EventArgs e)
        {
            DAL.clsSinhVien sv = new DAL.clsSinhVien
               (txtMaSV.Text, txtTenSV.Text
               , txtSDT.Text, txtQueQuan.Text, txtGhiChu.Text,dtpNgaySinh.Value);
            sv.Sua1SV(StrConectionString);
        }
    }
}
