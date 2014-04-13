using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace spaceNegocio
{
    public class CnxData
    {
        public CnxData()
        {
            
        }
        
        public static DataTable GetData(string sCommand)
        {
            SqlConnection connection = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=spaceapps;Data Source=MIGUEL-PC");
            SqlCommand cmd = new SqlCommand(sCommand, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            return ds.Tables[0];
        }
    }
}
