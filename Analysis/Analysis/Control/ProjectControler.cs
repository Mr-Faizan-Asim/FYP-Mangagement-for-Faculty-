using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analysis.Control
{
    internal class ProjectControler
    {
        public static void loadGrid(string table, DataGridView dataGrid)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("SELECT p.Id, p.Description, p.Title FROM [FYP].[dbo].[Project] AS p LEFT JOIN [FYP].[dbo].[GroupProject] AS gp ON p.Id = gp.ProjectId WHERE gp.ProjectId IS NULL;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }
        public static int InsertGroupProject(int projectId, int groupId, string assignmentDate)
        {
            if (projectId <= 0 || groupId < 0 || string.IsNullOrEmpty(assignmentDate))
            {
                return -1; 
            }

            var connection  = Configuration.getInstance().getConnection();
            int rowsAffected = -1;
                SqlCommand cmd = new SqlCommand("INSERT INTO [FYP].[dbo].[GroupProject] (ProjectId, GroupId, AssignmentDate) VALUES (@ProjectId, @GroupId, @AssignmentDate)", connection);
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Parse(assignmentDate)); 

                rowsAffected = cmd.ExecuteNonQuery();
            MessageBox.Show("ADDED");
            return rowsAffected;
        }

    }
}
