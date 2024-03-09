using Analysis.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Analysis.Control
{
    internal class GroupControler
    {
        public static void AddGroupWithInGroup(DataGridView dataGrid)
        {
            var con = Configuration.getInstance().getConnection();
     
            SqlCommand s = new SqlCommand("INSERT INTO [dbo].[Group] (Created_On) VALUES (GETDATE());", con);
            s.ExecuteNonQuery();
            MessageBox.Show("Work is Done");
            GenericControler.loadGrid("Group", dataGrid);
            int x = PersonControler.FindPersonLastId("[Group]");
            int StudentId = PersonControler.FindPersonIdByEmail(PersonLoginModel.LoginEmail);
            string GroupStudentQuery = "INSERT INTO [FYP].[dbo].[GroupStudent] ([GroupId] ,[StudentId] ,[Status] ,[AssignmentDate]) VALUES ('" + x + "','"+ StudentId + "','" + 3 + "',(GETDATE()) );";
            GenericControler.PerformerAll(GroupStudentQuery);
            GenericControler.loadGrid("GroupStudent", dataGrid);
        

        }
        public static void AddStudentInGroup(DataGridView dataGrid, int groupid)
        {

            int x = groupid;
            int StudentId = PersonControler.FindPersonIdByEmail(PersonLoginModel.LoginEmail);
            string GroupStudentQuery = "INSERT INTO [FYP].[dbo].[GroupStudent] ([GroupId] ,[StudentId] ,[Status] ,[AssignmentDate]) VALUES ('" + x + "','" + StudentId + "','" + 3 + "',(GETDATE()) );";
            GenericControler.PerformerAll(GroupStudentQuery);
            GenericControler.loadGrid("GroupStudent", dataGrid);
        }
        public static bool CheckExsistInTable()
        {
            var connection = Configuration.getInstance().getConnection();
      
            bool studentExists = false;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [FYP].[dbo].[GroupStudent] WHERE StudentId = @StudentId", connection);
            cmd.Parameters.AddWithValue("@StudentId", PersonControler.FindPersonIdByEmail(PersonLoginModel.LoginEmail));
            int count = (int)cmd.ExecuteScalar();
            studentExists = count > 0;
            cmd.ExecuteNonQuery();
       
            if (studentExists)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static int GetGroupIdByStudentId()
        {
            int groupId = -1;

            var connection = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT GroupId FROM [FYP].[dbo].[GroupStudent] WHERE StudentId = @StudentId", connection);
                cmd.Parameters.AddWithValue("@StudentId", PersonControler.FindPersonIdByEmail(PersonLoginModel.LoginEmail));

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        groupId = Convert.ToInt32(reader["GroupId"]);
                    }
                }

                reader.Close();
            

            return groupId;
        }
        public static bool CheckGroupExsistInTable(string groupid)
        {
            var connection = Configuration.getInstance().getConnection();
 
            bool studentExists = false;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [FYP].[dbo].[GroupStudent] WHERE GroupId = @GroupId", connection);
            cmd.Parameters.AddWithValue("@GroupId", groupid);
            int count = (int)cmd.ExecuteScalar();
            studentExists = count > 0;
            cmd.ExecuteNonQuery();
      
            if (studentExists)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
