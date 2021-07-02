using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.DAL
{
    class ClsMonhoc : IMonhoc
    {
        public string MaSV { get; set; }
        public string MaMH { get; set; }
        public float Diemlan1 { get; set; }
        public float Diemlan2 { get; set; }
        public string Ghichu { get; set; }
        public ClsMonhoc()
        { }
        public ClsMonhoc(string masv, string mamh,float 
            diemlan1, float diemlan2, string ghichu
            )
        { MaSV = masv;MaMH = masv;Diemlan1 = diemlan1;
            Diemlan2 = diemlan2;
        }

       public int Them1Monhoc(string Sqlconnectionstring)
        { return 0; }
       public int Sua1Monhoc(string Sqlconnectionstring)
        { return 0; }
        public int Xoa1Monhoc(string Sqlconnectionstring)
        { return 0; }
    }
}
