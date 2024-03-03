using Project.DL;
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

namespace Project.UI
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int po;
            if (FirstName.Text != null && LastName.Text != null && ContactBox.Text != null && int.TryParse(ContactBox.Text,out po) && int.TryParse(Gender.Text, out po) && emailLogon.Text != null)
            {
                int personID = Controler.IdGetterLast("Person");
                int countStudentReg = Controler.GetNumberofRecords("Student");
                var con = Configuration.getInstance().getConnection();
                SqlCommand personCmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)" +
                                                       " VALUES (@firstName, @lastName, @contact, @email, @dateOfBirth, @gender)", con);
                personCmd.Parameters.AddWithValue("@firstName", FirstName.Text);
                personCmd.Parameters.AddWithValue("@lastName", LastName.Text);
                personCmd.Parameters.AddWithValue("@contact", ContactBox.Text);
                personCmd.Parameters.AddWithValue("@email", emailLogon.Text);
                personCmd.Parameters.AddWithValue("@dateofbirth", DateTime.Parse(Date.Text));
                personCmd.Parameters.AddWithValue("@gender", Gender.Text);
                personCmd.ExecuteNonQuery();
                SqlCommand studentCmd = new SqlCommand("INSERT INTO Student (ID, RegistrationNo)" +
                                                       " VALUES (@ID, @RegistrationNo)", con);
                studentCmd.Parameters.AddWithValue("@ID", personID + 1);
                studentCmd.Parameters.AddWithValue("@RegistrationNo", (countStudentReg + 1)+"-UET");
                studentCmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
                

            }
            else
            {
                MessageBox.Show("Validations Error");
            }


        }
    }
}
