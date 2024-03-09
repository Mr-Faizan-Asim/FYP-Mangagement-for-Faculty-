using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analysis.Control
{
    internal class EvaluationControler
    {
        public static int InsertEvaluation(string name, double totalMarks, double totalWeightage)
        {
            if (string.IsNullOrEmpty(name) || totalMarks < 0 || totalWeightage < 0)
            {
                return -1; 
            }

            int rowsAffected = -1;
            var connection = Configuration.getInstance().getConnection();
               
                SqlCommand cmd = new SqlCommand("INSERT INTO [FYP].[dbo].[Evaluation] (Name, TotalMarks, TotalWeightage) VALUES (@Name, @TotalMarks, @TotalWeightage)", connection);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@TotalMarks", totalMarks);
                cmd.Parameters.AddWithValue("@TotalWeightage", totalWeightage);
            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Already Exsist"); }

            return rowsAffected;
        }

        public static int InsertGroupEvaluation(int groupId, int evaluationId, double obtainedMarks, string evaluationDate)
        {
            if (groupId <= 0 || evaluationId <= 0 || obtainedMarks < 0 || string.IsNullOrEmpty(evaluationDate))
            {
                return -1; 
            }

            int rowsAffected = 0;
            var connection = Configuration.getInstance().getConnection();
            
                // Check for duplicates before insert
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM [FYP].[dbo].[GroupEvaluation] WHERE GroupId = @GroupId AND EvaluationId = @EvaluationId", connection);
                checkCmd.Parameters.AddWithValue("@GroupId", groupId);
                checkCmd.Parameters.AddWithValue("@EvaluationId", evaluationId);

                
                int existingCount = (int)checkCmd.ExecuteScalar();

                if (existingCount == 0)
                {
                    // Insert data only if no duplicate found
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO [FYP].[dbo].[GroupEvaluation] (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES (@GroupId, @EvaluationId, @ObtainedMarks, @EvaluationDate)", connection);
                    insertCmd.Parameters.AddWithValue("@GroupId", groupId);
                    insertCmd.Parameters.AddWithValue("@EvaluationId", evaluationId);
                    insertCmd.Parameters.AddWithValue("@ObtainedMarks", obtainedMarks);
                    insertCmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Parse(evaluationDate));

                    rowsAffected = insertCmd.ExecuteNonQuery();
                }
            

            return rowsAffected; // Will be 0 if duplicate or insertion failed, otherwise number of rows affected
        }

    }
}
