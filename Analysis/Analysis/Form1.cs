using Analysis.Control;
using Analysis.Model;
using Analysis.View.Advisor;
using Analysis.View.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Core.Utils;

namespace Analysis
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           if(Checker())
            {
                bool pCheck = GenericControler.SearchPerson("where Email = '" + emailLogon.Text + "';", "Person");
                string stepper = GenericControler.stepperGetter(PasswordLogin.Text);
                int sectorSelector = GenericControler.LoginSector(stepper);
                if (pCheck && sectorSelector != 0)
                { 
                    if(sectorSelector == 1)
                    {

                    }
                    if (sectorSelector == 2)
                    {
                        AdvisorMainForm ad = new AdvisorMainForm();
                        ad.Show();
                    }
                    // Student
                    if (sectorSelector == 3)
                    {
                        StudentMainForm st = new StudentMainForm();
                        st.Show();
                    }
                    PersonLoginModel.LoginEmail = emailLogon.Text;
                    MessageBox.Show("Welcome");
                }
                else
                {
                    MessageBox.Show("Record Not Match");
                }
            }
        }
        public bool Checker()
        {
            if (emailLogon.Text != null && PasswordLogin.Text != null && (ValidationMod.EndsWithSuffix(emailLogon.Text, "@gmail.com") || ValidationMod.EndsWithSuffix(emailLogon.Text, "@outlook.com")))
            {
                return true;
            }

            MessageBox.Show("Fill It Correctly");
            return false;

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            StudentSignUpForm s = new StudentSignUpForm();
            s.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            AdvisorSignUp ad = new AdvisorSignUp();
            ad.Show();
            this.Hide();
        }
    }
}
