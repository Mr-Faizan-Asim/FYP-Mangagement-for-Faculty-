using Analysis.Control;
using Analysis.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Analysis.View.Student
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
            tabPage1.Text = "Delete Student";
            tabPage2.Text = "Update Student";
            tabPage3.Text = "Create New Group";
            tabPage4.Text = "Add in Group";
            tabPage5.Text = "Pickup Project";
            tabPage6.Text = "Vote For Project";
            tabPage7.Text = "Vote For Advisor";
            tabPage8.Text = "Results of Analysis";
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT p.Id, p.Description, p.Title FROM [FYP].[dbo].[Project] AS p LEFT JOIN [FYP].[dbo].[GroupProject] AS gp ON p.Id = gp.ProjectId WHERE gp.ProjectId IS NULL;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProjectIdSelect.Items.Add(reader.GetInt32(0));
            }
            reader.Close();

        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            int x = PersonControler.FindPersonIdByEmail(PersonLoginModel.LoginEmail);
            ID.Text = x.ToString();
            
            if (EMAIL.Text != null && ID.Text != null && int.TryParse(ID.Text,out int f)) {

                if (GenericControler.SearchPerson("where email = '" + EMAIL.Text + "' and Id = '" + ID.Text + "';" , "Person"))
                {

                    var con = Configuration.getInstance().getConnection();
                    if(GroupControler.CheckExsistInTable())
                    {
                        SqlCommand st = new SqlCommand("Delete from GroupStudent where StudentId = '" + ID.Text + "';", con);
                        st.ExecuteNonQuery();
                    }
                    SqlCommand s = new SqlCommand("Delete from student where id = '" +ID.Text +"';",con);
                    s.ExecuteNonQuery();
                    MessageBox.Show("Deleted Bye");
                    SignIn signIn = new SignIn();
                    signIn.Show();
                    
                }
                else
                {
                    MessageBox.Show("Fill Correctly And You Have Only Your Account Acess");
                }
            }
            else
            {
                MessageBox.Show("Fill Correctly");
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (!GroupControler.CheckExsistInTable() && !GroupControler.CheckExsistInTable())
            {
                GroupControler.AddGroupWithInGroup(GroupGrid);
            }
            else
            {
                MessageBox.Show("You Are Already in Someone Group");
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

            GenericControler.loadGrid("GroupStudent", GroupGrid);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            GenericControler.loadGrid("Group", GroupGrid);
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            if (groupId.Text != null && int.TryParse(groupId.Text, out int x))
            {
                if (!GroupControler.CheckGroupExsistInTable(groupId.Text) && !GroupControler.CheckExsistInTable())
                {
                    GroupControler.AddStudentInGroup(guna2GunaDataGrid1, (int.Parse(groupId.Text)));
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("You Are Already in Someone Group");
                }

            }
            else
            {
                MessageBox.Show("Fill It Correctly");
            }

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            GenericControler.loadGrid("Group", guna2GunaDataGrid1);
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            GenericControler.loadGrid("GroupStudent", guna2GunaDataGrid1);
        }

        

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            int x = GroupControler.GetGroupIdByStudentId();
            groupIdForStudent.Text = x.ToString();
            if(x != -1)
            {
                ProjectControler.InsertGroupProject(int.Parse(ProjectIdSelect.Text), x, guna2DateTimePicker1.Text);

            }
            else
            {
                MessageBox.Show("First Add Your Self In Any Group");
            }
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {

            ProjectControler.loadGrid("Project", guna2DataGridView2);
        }
    }
}
