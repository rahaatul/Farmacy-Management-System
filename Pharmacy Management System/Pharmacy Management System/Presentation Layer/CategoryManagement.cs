using Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer;
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
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryListDataGridView.DataSource = categoryDataAccess.GetAllCategories();
        }

        private void CategoryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
