using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_project_guides.Ultil
{
   public class Ultil
    {
        public bool ExcuteProcedure(string []paras, string []values,string strConnection,string sp_name)
        {
            bool kt = false;
            SqlConnection connection = new SqlConnection(strConnection);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sp_name;
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paras.Length; i++)
            {
                command.Parameters.AddWithValue(paras[i], values[i]);
            }
            try
            {
                command.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception)
            {                
            }    
            
            command.Dispose();
            connection.Dispose();
            return kt;

        }
    }
}
