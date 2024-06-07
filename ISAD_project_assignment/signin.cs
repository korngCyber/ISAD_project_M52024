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

namespace ISAD_project_assignment
{
    public partial class signin : Form
    {
        ConnectionDataBase _connectDatabase = new ConnectionDataBase();
        SqlCommand _command;
        public signin()
        {
            _connectDatabase.myConnection();
            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
                _command = new SqlCommand("loginUser", _connectDatabase.con);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@name", txtEmail.Text);
                _command.Parameters.AddWithValue("@password", txtPassword.Text);
                _command.ExecuteNonQuery();
                 SqlDataReader dr = _command.ExecuteReader();
                 if(dr.HasRows)
                 {
                      MessageBox.Show("loginSuccess");
                      this.Dispose();
                      new ContainerForm().Show();
                    
                 }
                 else
                 {
                     MessageBox.Show("login failed avalid account...!");
                 }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text=="")
            {
                txtEmail.Text = "exmaple@gmail.com";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text.Length > 0)
            {
                txtEmail.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                txtPassword.Text = "";
            }
        }

        private void linktoSingup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register register = new register();
            register.Show();
            this.Dispose();
        }
    }
}
