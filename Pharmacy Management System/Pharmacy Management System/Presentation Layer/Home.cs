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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeeDetails= new EmployeeDetails();
            employeeDetails.Show();
            this.Hide();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }


