using Analysis.Control;
using Analysis.Model;
using Guna.UI2.WinForms.Suite;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Analysis.View.Advisor
{
    public partial class AdvisorMainForm : Form
    {
        public AdvisorMainForm()
        {
            InitializeComponent();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Lookup where Category = 'ADVISOR_ROLE';", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guna2ComboBox1.Items.Add(reader.GetString(1));
            }
            reader.Close();
            tabPage1.Text = "Project";
            tabPage2.Text = "Evaluation";
            tabPage3.Text = "Evaluation Group";

            tabPage4.Text = "Report 1";
            tabPage5.Text = "Report 2";
            tabPage6.Text = "Report 3";
            tabPage7.Text = "Report 4";
            tabPage8.Text = "Report 5";
            SqlCommand emd = new SqlCommand("SELECT * FROM [FYP].[dbo].[Group]", con);
            SqlDataReader readerr = emd.ExecuteReader();
            while (readerr.Read())
            {
                GroupIdCombo.Items.Add(readerr.GetInt32(0));
            }
            readerr.Close();
            SqlCommand eemd = new SqlCommand("Select * from Evaluation;", con);
            SqlDataReader readerre = eemd.ExecuteReader();
            while (readerre.Read())
            {
                EvaluationIdCombo.Items.Add(readerre.GetInt32(0));
            }
            readerre.Close();

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AdvisorMainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (projectTitle.Text != null && ProjectDis.Text != null)
            {

                var connection = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO [FYP].[dbo].[Project] (Title, Description) VALUES (@Title, @Description)", connection);
                cmd.Parameters.AddWithValue("@Title", projectTitle.Text);
                cmd.Parameters.AddWithValue("@Description", ProjectDis.Text);
                cmd.ExecuteNonQuery();
                int ProjectId = PersonControler.FindPersonLastId("Project");
                int Advisorid = PersonControler.FindPersonIdByEmail(PersonLoginModel.LoginEmail);
                SqlCommand checker = new SqlCommand("Select id from Lookup where Value = @value", connection);
                checker.Parameters.AddWithValue("@value", guna2ComboBox1.Text);
                int selectedId = 11;
                try
                {
                    SqlDataReader reader = checker.ExecuteReader();

                    if (reader.Read())
                    {
                        selectedId = reader.GetInt32(0);
                    }
                    else
                    {
                        selectedId = -1;
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);

                }
                SqlCommand pmd = new SqlCommand("INSERT INTO [FYP].[dbo].[ProjectAdvisor] (ProjectId, AdvisorId, AdvisorRole, AssignmentDate) VALUES (@ProjectId, @AdvisorId, @AdvisorRole, @AssignmentDate)", connection);
                pmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                pmd.Parameters.AddWithValue("@AdvisorId", Advisorid);
                pmd.Parameters.AddWithValue("@AdvisorRole", selectedId);
                pmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now); // Assuming assignmentDate is in a valid date format
                pmd.ExecuteNonQuery();
                GenericControler.loadGrid("ProjectAdvisor", guna2GunaDataGrid1);

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GenericControler.loadGrid("Evaluation", evaGrid);
        }

        private void AddEva_Click(object sender, EventArgs e)
        {
            if (evname.Text != null && int.TryParse(evTotalMarks.Text, out int p) && int.TryParse(evwei.Text, out int x))
            {
                int c = EvaluationControler.InsertEvaluation(evname.Text, int.Parse(evTotalMarks.Text), int.Parse(evwei.Text));
                if (c == -1)
                {
                    MessageBox.Show("Something Is Wrong");
                }
                else
                {
                    MessageBox.Show("Done");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GenericControler.loadGrid("GroupEvaluation", guna2DataGridView2);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (obtainTextBox.Text != null && int.TryParse(obtainTextBox.Text, out int p))
            {
                int c = EvaluationControler.InsertGroupEvaluation(int.Parse(GroupIdCombo.Text), int.Parse(EvaluationIdCombo.Text), double.Parse(obtainTextBox.Text), dateTimer.Text);
                if (c == -1)
                {
                    MessageBox.Show("Something Is Wrong");
                }
                else
                {
                    MessageBox.Show("Done");
                }

            }
            else
            {
                MessageBox.Show("Fill it Correctly");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            GenericControler.loadGrid("Group", guna2DataGridView2);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            var con3 = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand(@"
    SELECT 
        CONCAT(S.FirstName, ' ', S.LastName) AS StudentName,
        CONCAT(A.FirstName, ' ', A.LastName) AS AdvisorName
    FROM 
        GroupStudent AS GS
    JOIN 
        Person AS S ON GS.StudentID = S.ID
    JOIN 
        GroupProject AS GP ON GS.GroupID = GP.GroupID
    JOIN 
        ProjectAdvisor AS PA ON GP.ProjectID = PA.ProjectID
    JOIN 
        Person AS A ON PA.AdvisorID = A.ID
    ORDER BY 
        StudentName", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            GunaDataGrid1.DataSource = dt3;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (GunaDataGrid1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(GunaDataGrid1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in GunaDataGrid1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in GunaDataGrid1.Rows)
                            {
                                if (viewRow.Cells != null)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null) // Add null check for the cell value
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell(""); // Add an empty cell if the value is null
                                        }
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            var con3 = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand(@"
SELECT p.Title AS ProjectTitle,
       s.FirstName AS StudentFirstName,
       s.LastName AS StudentLastName,
       e.Name AS EvaluationName,
       ge.ObtainedMarks AS Marks,
       SUM(ge.ObtainedMarks) OVER (PARTITION BY p.Id, s.Id) AS TotalMarks
FROM Project p
INNER JOIN GroupProject gp ON p.Id = gp.ProjectId
INNER JOIN GroupStudent gs ON gp.GroupId = gs.GroupId
INNER JOIN Person s ON gs.StudentId = s.Id  -- Assuming Student table has FirstName, LastName, and Marks columns
INNER JOIN GroupEvaluation ge ON gp.GroupId = ge.GroupId
INNER JOIN Evaluation e ON ge.EvaluationId = e.Id
ORDER BY p.Title, s.LastName, s.FirstName, e.Name;
", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            guna2.DataSource = dt3;
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if (guna2.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(guna2.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in guna2.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in guna2.Rows)
                            {
                                if (viewRow.Cells != null)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null) // Add null check for the cell value
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell(""); // Add an empty cell if the value is null
                                        }
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            var con3 = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand(@"
SELECT p.Title AS ProjectTitle,
       (SELECT STUFF((SELECT ', ' + l.Value
                       FROM Advisor a
                       INNER JOIN ProjectAdvisor pa ON a.Id = pa.AdvisorId  
                       INNER JOIN Lookup l ON a.Designation = l.Id  
                       WHERE pa.ProjectId = p.Id  -- Match ProjectId from ProjectAdvisor
                       FOR XML PATH('')), 1, 2, '')) AS AdvisoryBoard,
       (SELECT STUFF((SELECT ', ' + CONCAT(s.FirstName, ' ', s.LastName)
                       FROM GroupStudent gs
                       INNER JOIN Person s ON gs.StudentId = s.Id  -- Assuming ""StudentId"" is the foreign key referencing ""Student""
                       WHERE gs.GroupId IN (SELECT GroupId FROM GroupProject WHERE ProjectId = p.Id)
                       FOR XML PATH('')), 1, 2, '')) AS Students
FROM Project p;
", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            ada.DataSource = dt3;
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            if (ada.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(ada.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in ada.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in ada.Rows)
                            {
                                if (viewRow.Cells != null)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null) // Add null check for the cell value
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell(""); // Add an empty cell if the value is null
                                        }
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            var con3 = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand(@"
SELECT s.FirstName AS StudentFirstName,
       s.LastName AS StudentLastName,
       AVG(ge.ObtainedMarks) AS AverageMarks
FROM Person s
INNER JOIN GroupStudent gs ON s.Id = gs.StudentId
INNER JOIN GroupProject gp ON gs.GroupId = gp.GroupId
INNER JOIN GroupEvaluation ge ON gp.GroupId = ge.GroupId
GROUP BY s.Id, s.FirstName, s.LastName
ORDER BY s.LastName, s.FirstName;
", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            aad.DataSource = dt3;
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            if (aad.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(aad.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in aad.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in aad.Rows)
                            {
                                if (viewRow.Cells != null)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null) // Add null check for the cell value
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell(""); // Add an empty cell if the value is null
                                        }
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {
            var con3 = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand(@"
SELECT p.Title AS ProjectTitle,
       COUNT(DISTINCT gs.StudentId) AS TotalStudents,
       COUNT(ge.GroupId) AS CompletedProjects,
       (COUNT(ge.GroupId) / COUNT(DISTINCT gs.StudentId)) * 100 AS CompletionRate
FROM Project p
INNER JOIN GroupProject gp ON p.Id = gp.ProjectId
INNER JOIN GroupStudent gs ON gp.GroupId = gs.GroupId
LEFT JOIN GroupEvaluation ge ON gp.GroupId = ge.GroupId
GROUP BY p.Id, p.Title
HAVING COUNT(DISTINCT gs.StudentId) > 0;
", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            adad.DataSource = dt3;
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            if (adad.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(adad.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in adad.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in adad.Rows)
                            {
                                if (viewRow.Cells != null)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null) // Add null check for the cell value
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell(""); // Add an empty cell if the value is null
                                        }
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}
