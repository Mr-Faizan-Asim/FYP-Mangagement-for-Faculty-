using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Analysis.Control
{
    internal class StudentControler
    {
        public static void AddStudent(string queryForPerson,string tableNamePerson,string studentTable,Label l)
        {
            GenericControler.PerformerAll(queryForPerson);
            // ya last id lata ha
            int id = PersonControler.FindPersonLastId(tableNamePerson);
            var con = Configuration.getInstance().getConnection();
   
            SqlCommand studentCmd = new SqlCommand("INSERT INTO Student (ID, RegistrationNo)" + " VALUES (@ID, @RegistrationNo)", con);
            studentCmd.Parameters.AddWithValue("@ID", id);
            studentCmd.Parameters.AddWithValue("@RegistrationNo", (id + 1) + "-UET");
            studentCmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            l.Text = "Region is " + (id);

        }
    }
}
