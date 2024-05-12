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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "korng" && txtPassword.Text == "12345")
            {
                MessageBox.Show("log in success");
                ContainerForm containerForm = new ContainerForm();
                containerForm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Invalid Email or password please check you username and password again...!");

            }

        }
    }
}
