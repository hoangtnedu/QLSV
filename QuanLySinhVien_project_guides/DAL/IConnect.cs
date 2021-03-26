using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.DAL
{
    interface IConnect
    {
        string UserID { get; set; }
        string Password { get; set; }
        string Database { get; set; }
        string Server { get; set; }
        string GetConnectionString();
        SqlConnection Connect();
    }
}
