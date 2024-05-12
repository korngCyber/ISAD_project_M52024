using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD_project_assignment
{
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
           form1.Show(); 
            this.Hide();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm supform = new SupplierForm();  
            supform.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            PorductForm productform = new PorductForm();
            productform.Show();

            this.Hide();
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffForm staffform = new StaffForm();  
            staffform.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
