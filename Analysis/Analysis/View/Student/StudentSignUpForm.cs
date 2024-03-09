using Analysis.Control;
using Analysis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analysis.View.Student
{
    public partial class StudentSignUpForm : Form
    {
        public StudentSignUpForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = " INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender)" + " VALUES ( '"+ FirstName.Text + "','"+LastName.Text+"' ,'" + ContactBox.Text+"','"+ emailLogon.Text+"','" + (DateTime.Parse(Date.Text)) + "'," +Gender.Text +")";
            if (!GenericControler.SearchPerson("where Email = '" + emailLogon.Text +"';","Person") && emailLogon.Text != null && FirstName.Text != null && LastName.Text != null && ContactBox.Text != null && Gender.Text != null && int.TryParse(Gender.Text,out int x) && (ValidationMod.EndsWithSuffix(emailLogon.Text, "@gmail.com") || ValidationMod.EndsWithSuffix(emailLogon.Text, "@outlook.com")))
            {
                StudentControler.AddStudent(query, "Person", "Student",RegistrationNumber);
                StudentMainForm s = new StudentMainForm();
                PersonLoginModel.LoginEmail = emailLogon.Text;
                s.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error is Here Check All Thing Again");
            }
        }

        private void StudentSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn s = new SignIn();
            s.Show();
        }
    }
}
