using Analysis.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Analysis.Control
{
    internal class GenericControler
    {
        public static bool SearchPerson( string query,string table)
        {
            
            var connection = Configuration.getInstance().getConnection();
            SqlCommand sqlCommand = new SqlCommand("Select * from " + table + " " + query, connection);
           
            var x = sqlCommand.ExecuteScalar();
            sqlCommand.ExecuteNonQuery();
          
            if (x!= null)
            {
                return true;
            }
            return false;
        }
        public static void PerformerAll(string query)
        {
            var connection = Configuration.getInstance().getConnection();
          
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
        
        }
        public static int LoginSector(string stepper)
        {
            if(stepper == AdminModel.AdminPassKey)
            {
                return 1;
            }
            if (stepper == AdminModel.TeacherPassKey)
            {
                return 2;
            }
            if (stepper == AdminModel.StudentPassKey)
            {
                return 3;
            }
            return 0;
        }
        public static string stepperGetter(string password)
        {
            string stepper = "";
            if (password != null && password.Length > AdminModel.stepperLength)
            {
                for (int i = 0; i < AdminModel.stepperLength; i++)
                {
                    stepper = stepper + password[i];
                }
            }
            return stepper;
        }
        public static void loadGrid(string table, DataGridView dataGrid)
        {
            var con = Configuration.getInstance().getConnection();
           
            SqlCommand cmd = new SqlCommand("Select * from [" + table + "] ;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
         
        }
    }
}
