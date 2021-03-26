using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_project_guides.GUI
{

    public partial class FrmConnect : Form
    {/// <summary>
     ///Thêm thuộc tính StrConectionString
     /// </summary>

        public FrmConnect()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
        }
        public string StrConectionString;
        private void btbKetNoi_Click(object sender, EventArgs e)
        {
            DAL.clsConnect connect = new DAL.clsConnect(
                txtTenDangNhap.Text, txtMatKhau.Text,
                txtTenCSDL.Text, txtTenMayChu.Text);
            if (connect.Connect() != null)
            {
                lblThongbaotrangthai.Text = "Kết nối thành công";
                lblThongbaotrangthai.BackColor = Color.Aqua;
                lblThongbaotrangthai.ForeColor = Color.Green;
                //Gán giá trị cho thuộc tính vừa thêm
                StrConectionString = connect.GetConnectionString();
            }
            else
            {
                lblThongbaotrangthai.Text = "Kết nối thất bại";
                lblThongbaotrangthai.BackColor = Color.Red;
                lblThongbaotrangthai.ForeColor = Color.Yellow;
            }
        }


        private void chbHienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHienthimatkhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }

        }
    }
}
