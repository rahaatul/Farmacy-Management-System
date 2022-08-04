using Pharmacy_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
                if (employeeDataAccess.LoginValidation(usernameTextBox.Text, passwordTextBox.Text))
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

            }
        }
        

        private void userRegistrationLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Show();
            this.Hide();
        }
    }
}

