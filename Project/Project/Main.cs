using Project.DL;
using Project.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Controler.CheckerType = "Student";
            StudentUI s = new StudentUI();
            s.Show();

        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            Controler.CheckerType = "Teacher";
            SignUpAdvisor s = new SignUpAdvisor();
            s.Show();
        }
        
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from Person as p where p.Id = @id and p.Email = @email and ((Select Id from Advisor where @id = Advisor.id) is not null);", con);
            cmd.Parameters.AddWithValue("@email", (emailLogon.Text));
            cmd.Parameters.AddWithValue("@id", NameLogin.Text);
            SqlDataReader reader = cmd.ExecuteReader();
           
            if (reader.HasRows)
            {

                reader.Close();
                MessageBox.Show("Welcome Sir G");
            }
            else
            {
                SqlCommand md = new SqlCommand("SELECT * from Person as p where p.Id = @id and p.Email = @email;", con);
                md.Parameters.AddWithValue("@email", (emailLogon.Text));
                md.Parameters.AddWithValue("@id", NameLogin.Text);
                reader.Close();
                reader = md.ExecuteReader();
                if(reader.HasRows)
                {

                    reader.Close();
                    MessageBox.Show("Welcome Student");
                }
                else
                {

                    reader.Close();
                    MessageBox.Show("Record Not Found");
                }
                md.ExecuteNonQuery();
            }
            cmd.ExecuteNonQuery();


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
