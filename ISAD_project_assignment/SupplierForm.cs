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
    public partial class SupplierForm : Form
    {
        ConnectionDataBase _connectDatabase = new ConnectionDataBase();
        SqlCommand _command;
        SqlDataAdapter _adapter;
        DataTable _datable;
        public SupplierForm()
        {
            _connectDatabase.myConnection();
            InitializeComponent();
            FetchData();
        }
        private void clearTxt()
        {
            txtSupID.Text = "";
            txtSupName.Text = "";
            txtSubCon.Text = "";
            comboSubAdd.SelectedIndex = -1;
        }
        public void FetchData()
        {
            TableSup.DataSource = null;
            _command = new SqlCommand("fetchSupplier", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;


            SqlDependency _sqlDependency = new SqlDependency(_command);
            //_sqlDependency.OnChange += OnChangeEventHandler(OnChange);
            _sqlDependency.OnChange += OnChange;


            _adapter = new SqlDataAdapter(_command);
            _datable = new DataTable();
            _adapter.Fill(_datable);

            TableSup.DataSource = _datable;

        }
        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                TableSup.BeginInvoke(new MethodInvoker(FetchData));
            }
            else
            {
                FetchData();
            }
        }

        private void btnSupsave_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("AddSupplier", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Sname", txtSupName.Text);
            _command.Parameters.AddWithValue("@Scon", txtSubCon.Text);
            _command.Parameters.AddWithValue("@Sadd", comboSubAdd.Text);

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");

        }

        private void btnSupDelete_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("DeleteSupplier", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Sid", txtSupID.Text);
         

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");
        }

        private void TableSup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = TableSup.Rows[i];
            txtSupID.Text = row.Cells[0].Value.ToString();
            txtSupName.Text = row.Cells[1].Value.ToString();
            comboSubAdd.Text = row.Cells[2].Value.ToString();
            txtSubCon.Text = row.Cells[3].Value.ToString();
        }

        private void btnSuppdate_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("UpdateSupplier", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Sname", txtSupName.Text);
            _command.Parameters.AddWithValue("@Sadd", comboSubAdd.Text);
            _command.Parameters.AddWithValue("@Scon", txtSubCon.Text);
            _command.Parameters.AddWithValue("@Sid",txtSupID.Text); 

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");
        }

        private void btnsupExit_Click(object sender, EventArgs e)
        {
            ContainerForm containerForm = new ContainerForm();
            containerForm.Show();
            this.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (TableSup.DataSource is DataTable dataTable)
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
                searchBox.Text ="";
            }
        }
       
    }
}
