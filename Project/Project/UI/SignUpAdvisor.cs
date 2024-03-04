﻿using Project.DL;
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
    public partial class SignUpAdvisor : Form
    {
        public SignUpAdvisor()
        {
            InitializeComponent();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Lookup where Category = 'DESIGNATION';", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guna2ComboBox1.Items.Add(reader.GetString(1)); 
            }
            reader.Close(); 
        }
        private void changer_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int po;
            if (FirstName.Text != null && LastName.Text != null && ContactBox.Text != null && int.TryParse(ContactBox.Text, out po) && int.TryParse(Gender.Text, out po) && emailLogon.Text != null)
            {
                int personID = Controler.IdGetterLast("Person");
                // Person


                var con = Configuration.getInstance().getConnection();

                SqlCommand checker = new SqlCommand("Select id from Lookup where Value = @value", con);
                checker.Parameters.AddWithValue("@value", guna2ComboBox1.Text); 
                int selectedId = 6;
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
                try
                {

                    SqlCommand personCmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)" +
                                                           " VALUES (@firstName, @lastName, @contact, @email, @dateOfBirth, @gender)", con);
                    personCmd.Parameters.AddWithValue("@firstName", FirstName.Text);
                    personCmd.Parameters.AddWithValue("@lastName", LastName.Text);
                    personCmd.Parameters.AddWithValue("@contact", ContactBox.Text);
                    personCmd.Parameters.AddWithValue("@email", emailLogon.Text);
                    personCmd.Parameters.AddWithValue("@dateofbirth", DateTime.Parse(Date.Text));
                    personCmd.Parameters.AddWithValue("@gender", Gender.Text);
                    personCmd.ExecuteNonQuery();
                    // Advisors

                    SqlCommand AdvisorCmd = new SqlCommand("INSERT INTO Advisor (Id,Designation,Salary)" +
                                                               " VALUES (@Id, @Designation, @Salary)", con);
                    AdvisorCmd.Parameters.AddWithValue("@Id", personID + 1);
                    AdvisorCmd.Parameters.AddWithValue("@Salary", salary.Text);
                    AdvisorCmd.Parameters.AddWithValue("@Designation", selectedId);
                    AdvisorCmd.ExecuteNonQuery();
                    MessageBox.Show("Work is Done");
                }
                catch
                {
                    MessageBox.Show("Validation Error Or Record Already Exsist");
                }
              

            }


        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
