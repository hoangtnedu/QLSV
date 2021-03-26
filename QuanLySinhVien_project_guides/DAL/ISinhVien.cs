using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.DAL
{
    interface ISinhVien
    {
        string MaSV { get; set; }
        string TenSV { get; set; }
        string SDT { get; set; }
        string QueQuan { get; set; }
        string GhiChu { get; set; }
        int Them1SV(string strSqlConnection);
        int Sua1SV(string strSqlConnection);
        int Xoa1SV(string strSqlConnection);
    }
}
