using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD_project_assignment
{
    public partial class Form1 : Form
    {
        ConnectionDataBase _connectDatabase = new ConnectionDataBase();
        SqlCommand _command;
        SqlDataAdapter _adapter;
        DataTable _datable;

        public Form1()
        {
            _connectDatabase.myConnection();
            InitializeComponent();
            FetchData();
        }
        private void clearTxt()
        {
            txtCusId.Text = "";
            txtCusName.Text = "";
            txtCusCon.Text = "";
        }
        public void FetchData()
        {
            TableCus.DataSource = null;
            _command = new SqlCommand("fetchCustomer",_connectDatabase.con);  
            _command.CommandType = CommandType.StoredProcedure; 
         

            SqlDependency _sqlDependency = new SqlDependency(_command);
            //_sqlDependency.OnChange += OnChangeEventHandler(OnChange);
            _sqlDependency.OnChange += OnChange;


            _adapter = new SqlDataAdapter(_command);
            _datable = new DataTable();
            _adapter.Fill(_datable);

            TableCus.DataSource = _datable;

        }
        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if(this.InvokeRequired)
            {
                TableCus.BeginInvoke(new MethodInvoker(FetchData));
            }
            else
            {
                FetchData();    
            }
        }

        private void btnCussave_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("AddCustomer", _connectDatabase.con);
            _command.CommandType= CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Cname",txtCusName.Text); 
            _command.Parameters.AddWithValue("@Ccon",txtCusCon.Text);

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");
        }

        private void TableCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i=e.RowIndex;
            DataGridViewRow row = TableCus.Rows[i];
            txtCusId.Text = row.Cells[0].Value.ToString();
            txtCusName.Text= row.Cells[1].Value.ToString();
            txtCusCon.Text = row.Cells[2].Value.ToString(); 
        }

        private void btnCuspdate_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("UpdateCustomer", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Cname", txtCusName.Text);
            _command.Parameters.AddWithValue("@Ccon", txtCusCon.Text);
            _command.Parameters.AddWithValue("@Cid",txtCusId.Text); 

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Updated....!");

        }

        private void btnCusDelete_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("DeleteCustomer", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Cid", txtCusId.Text);
            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Deleted....!");

        }

       

        private void btnCusExit_Click(object sender, EventArgs e)
        {
            /*SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();*/

            PorductForm porductForm = new PorductForm();
            porductForm.Show();
        }

       

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ContainerForm containerForm = new ContainerForm();
            containerForm.Show();

            this.Close();
        }

       

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (TableCus.DataSource is DataTable dataTable)
            {
                if (int.TryParse(searchBox.Text, out int id))
                {
                    dataTable.DefaultView.RowFilter = string.Format("ID = {0}", id);
                }
                else
                {
                    dataTable.DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", searchBox.Text);
                }
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search")
            {
                searchBox.Text = "";
            }
        }

       
    }
}
