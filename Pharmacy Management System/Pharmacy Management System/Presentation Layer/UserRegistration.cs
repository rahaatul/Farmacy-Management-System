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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
            submitButton.Enabled = false;
        }
        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }
        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked)
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (usernamecomboBox.Text == "")
            {
                MessageBox.Show("Select a UserName");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be empty");
            }
            else if (dateOfBirthDateTimePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Select proper date of birth");
            }
            else if ((maleRadioButton.Checked == false) && (femaleRadioButton.Checked == false))
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select a blood group");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }
                else
                {
                   
                    User user = new User();
                    user.Name = nameTextBox.Text;
                    user.Username = usernamecomboBox.Text;
                    user.Email = emailTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.DateOfBirth = dateOfBirthDateTimePicker.Text;
                    if (maleRadioButton.Checked)
                    {
                        user.Gender = "Male";
                    }
                    else
                    {
                        user.Gender = "Female";
                    }
                    user.BloodGroup = bloodGroupComboBox.Text;

                    
                    UserDataAccess userDataAccess = new UserDataAccess();

                    if (userDataAccess.UserRegister(user))
                    {
                        MessageBox.Show("User registered successfully");
                        Login login = new Login();
                        login.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error in registration");
                    }
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
