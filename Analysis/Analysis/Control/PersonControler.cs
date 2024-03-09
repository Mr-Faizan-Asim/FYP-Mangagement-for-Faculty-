using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis.Control
{
    internal class PersonControler
    {
        public static int FindPersonLastId(string tableName)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 Id FROM " + tableName + " ORDER BY Id DESC", con); // Use TOP 1 for SQL Server
            int lastId;
           
            var result = cmd.ExecuteScalar();
            lastId = result == null ? 1 : (int)result;
        
            return lastId;

        }
        public static int FindPersonIdByEmail(string email)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Person WHERE Email = @email", con);
            cmd.Parameters.AddWithValue("@email", email);

            int id = -1;
            try
            {
                object result = cmd.ExecuteScalar();
                if (result == DBNull.Value)
                {
                    id = -1; 
                }
                else
                {
                    id = (int)result;
                }
            }
            catch (SqlException ex)
            {
                throw ex; 
            }
            return id;
        }
    }
}
