using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT02K20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoginSQL_Click(object sender, EventArgs e)
        {
            string sqlConnectionString = "";
            sqlConnectionString += "Data Source =" + txtServer.Text.Trim();
            sqlConnectionString += ";Initial Catalog=" + txtDatabase.Text.Trim();
            sqlConnectionString += ";User ID=" + txtUserID.Text.Trim();
            sqlConnectionString += ";Password=" + txtPassword.Text.Trim();
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            try
            {
                connection.Open();
                lblThongBao.Text = "Kết nối thành công đến server " + txtServer.Text;
            }
            catch(SqlException ex)
            {
                lblThongBao.Text = "Kết nối thất bại đến " + txtServer.Text;
            }
            finally
            {
                connection.Dispose();
            }
        }

        private void btnWindows_Click(object sender, EventArgs e)
        {
           string sqlConnectionString= @"Data Source= DESKTOP-H68FGFI\SQLSERVER;" +
                "Initial Catalog = QLSV;" +
                "Integrated Security = True";
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            try
            {
                connection.Open();
                lblThongBao.Text = "Kết nối thành công đến server " + txtServer.Text;
            }
            catch (SqlException ex)
            {
                lblThongBao.Text = "Kết nối thất bại đến " + txtServer.Text;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
