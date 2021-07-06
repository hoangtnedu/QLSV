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
        public int Them1Diem()
        {
            return 0;
        }
        public int Xoa1Diem()
        {
            return 0;
        }
        public int Sua1Diem()
        {
            return 0;
        }
    }
}
