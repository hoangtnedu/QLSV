using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_project_guides
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strConectionstring;
        private void kếtNốiCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.FrmConnect frm = new GUI.FrmConnect();          
            frm.ShowDialog();
            strConectionstring = frm.StrConectionString;
        }

        private void ketNoiBangQuyenWinodwsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmConnectbyWindows frm = new GUI.frmConnectbyWindows();
            frm.ShowDialog();
        }

        private void tTSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.frmSinhVien frm = new GUI.frmSinhVien(strConectionstring);
            frm.ShowDialog();
        }

        private void tTSVKetNoiTructiepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmSV frm = new GUI.frmSV();
            frm.ShowDialog();
        }

        private void báoCáoSinhViênĐangHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmReportSV frm = new GUI.frmReportSV();
            frm.ShowDialog();
        }

        private void bCSinhVieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmSinhVienK19IT02 frm =new GUI.frmSinhVienK19IT02();
            frm.ShowDialog();
        }
    }
}
