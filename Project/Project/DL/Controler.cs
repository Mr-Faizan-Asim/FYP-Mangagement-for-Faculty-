using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DL
{
    public class Controler
    {
        private static string checkerType = "";

        public static string CheckerType { get => checkerType; set => checkerType = value; }
        
        public static int GetNumberofRecords(string tableName)
        {
             var c = Configuration.getInstance().getConnection();
            SqlCommand s = new SqlCommand("Select Count(*) from " + tableName,c);
            int count = (int)s.ExecuteScalar();
            return count;
        }
        
        public static int IdGetterLast(string tableName)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 Id FROM " + tableName + " ORDER BY Id DESC", con); // Use TOP 1 for SQL Server
            int lastId;
            try
            {
                object result = cmd.ExecuteScalar();
                lastId = result == null ? 0 : (int)result; // Handle null result (no records)
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return lastId;
        }
    }
}
