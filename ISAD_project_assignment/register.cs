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
    public partial class register : Form
    {
        ConnectionDataBase _connectDatabase = new ConnectionDataBase();
        SqlCommand _command;
        public register()
        {
            _connectDatabase.myConnection();
            InitializeComponent();
        }

       

        private void txtUpUser_Enter(object sender, EventArgs e)
        {
            if (txtUpUser.Text.Length > 0)
            {
                txtUpUser.Text = "";
            }
        }

        private void txtUpUser_Leave(object sender, EventArgs e)
        {
            if (txtUpUser.Text == "")
            {
                txtUpUser.Text = "exmaple@gmail.com";
            }
        }

        private void txtUppassword_Leave(object sender, EventArgs e)
        {
            if (txtUppassword.Text == "")
            {
                txtUppassword.Text = "Password";
            }
        }

        private void txtUppassword_Enter(object sender, EventArgs e)
        {
            if (txtUppassword.Text.Length > 0)
            {
                txtUppassword.Text = "";
            }
        }

        private void txtUpConpassword_Enter(object sender, EventArgs e)
        {
            if (txtUpConpassword.Text.Length > 0)
            {
                txtUpConpassword.Text = "";
            }
        }

        private void txtUpConpassword_Leave(object sender, EventArgs e)
        {
            if (txtUpConpassword.Text == "")
            {
                txtUpConpassword.Text = "Password";
            } 
        }

        private void MoveTologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            new signin().Show();
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            if (txtUppassword.Text == txtUpConpassword.Text) {
                _command = new SqlCommand("registerUser", _connectDatabase.con);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@name", txtUpUser.Text);
                _command.Parameters.AddWithValue("@password", txtUppassword.Text);
                _command.ExecuteNonQuery();
                MessageBox.Show("Account Created....!");
            }
            else
            {
                MessageBox.Show("passowrd and confirm password are differnt....falied to sign up....!");
            }
        }
    }
}
