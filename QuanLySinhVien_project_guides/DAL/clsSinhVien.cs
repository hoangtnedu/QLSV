using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.DAL
{
    class clsSinhVien : ISinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string SDT { get; set; }
        public string QueQuan { get; set; }
        public string GhiChu { get; set; }
        public clsSinhVien(string _masv, string _tensv,
            string _sdt, string _quequan,string _ghichu)
        {
            MaSV = _masv; TenSV = _tensv; SDT = _sdt; QueQuan = _quequan;GhiChu = _ghichu;
        }
        public int Them1SV(string strConection)
        {
            SqlConnection connection = new SqlConnection(strConection);           
            if (connection.State == ConnectionState.Closed) connection.Open();            
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "sp_Them1SV";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaSV",MaSV );
            command.Parameters.AddWithValue("@TenSV", TenSV);
            command.Parameters.AddWithValue("@SDT", SDT);
            command.Parameters.AddWithValue("@QueQuan", QueQuan);
            command.Parameters.AddWithValue("@GhiChu", GhiChu);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Dispose();
            return 0;
        }
        public int Sua1SV(string strConection) {
            SqlConnection connection = new SqlConnection(strConection);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "sp_Sua1SV";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaSV", MaSV);
            command.Parameters.AddWithValue("@TenSV", TenSV);
            command.Parameters.AddWithValue("@SDT", SDT);
            command.Parameters.AddWithValue("@QueQuan", QueQuan);
            command.Parameters.AddWithValue("@GhiChu", GhiChu);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Dispose();
            return 0;
          }
        public int Xoa1SV(string strConection) { return 0; }
    }
}
