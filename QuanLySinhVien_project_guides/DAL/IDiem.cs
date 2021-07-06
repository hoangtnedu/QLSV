using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.DAL
{
    interface IDiem
    {
        string MaSV { get; set; }
        string MaMH { get; set; }
        float DiemLan1 { get; set; }
        float DiemLan2 { get; set; }
        string GhiChu { get; set; }
        int Them1Diem(string strSqlConnection);
        int Xoa1Diem(string strSqlConnection);
        int Sua1Diem(string strSqlConnection);
    }
}
