using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.DAL
{
    interface IMonhoc
    {
        string MaSV { get; set; }
        string MaMH { get; set; }
        float Diemlan1 { get; set; }
        float Diemlan2 { get; set; }
        string Ghichu { get; set; }
        int Them1Monhoc(string Sqlconnectionstring);
        int Sua1Monhoc(string Sqlconnectionstring);
        int Xoa1Monhoc(string Sqlconnectionstring);
    }
}
