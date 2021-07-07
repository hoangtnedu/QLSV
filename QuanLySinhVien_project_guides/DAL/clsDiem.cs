using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.DAL
{
    class clsDiem : IDiem
    {
        public string MaSV { get; set; }
        public string MaMH { get; set; }
        public float DiemLan1 { get; set; }
        public float DiemLan2 { get; set; }
        public string GhiChu { get; set; }
        public int Them1Diem(string strSqlConnection)
        {
            return Ultil.Ultil.ExcuteProcedure(
            new string[] { "@MaSV", "@MaMH","@DiemLan1","@DiemLan2","@GhiChu" },
            new object[] { MaSV, MaMH,DiemLan1,DiemLan2,GhiChu },
            strSqlConnection,
            "Sp_Insert1Diem");
        }
        public int Xoa1Diem(string strSqlConnection)
        {
            return Ultil.Ultil.ExcuteProcedure(
            new string[] { "@MaSV", "@MaMH" },
            new string[] { MaSV, MaMH },
            strSqlConnection,
            "Sp_Delete1Diem");
        }
        public int Sua1Diem(string strSqlConnection)
        {
            return Ultil.Ultil.ExcuteProcedure(
            new string[] { "@MaSV", "@MaMH", "@DiemLan1", "@DiemLan2", "@GhiChu" },
            new object[] { MaSV, MaMH, DiemLan1, DiemLan2, GhiChu },
            strSqlConnection,
            "Sp_Update1Diem ");
        }
    }
}
