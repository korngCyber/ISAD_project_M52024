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
    public partial class PorductForm : Form
    {
        ConnectionDataBase _connectDatabase = new ConnectionDataBase();
        SqlCommand _command;
        SqlDataAdapter _adapter;
        DataTable _datable;
        public PorductForm()
        {
            _connectDatabase.myConnection();
            InitializeComponent();
            FetchData();
        }
        private void clearTxt()
        {
            txtProID.Text = "";
            txtPRoName.Text = "";
            txtProQTY.Text = "";
            txtProUnitPRice.Text = "";
            txtProSalePrice.Text = "";

        }
        public void FetchData()
        {
            TablePro.DataSource = null;
            _command = new SqlCommand("fetchProduct", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;


            SqlDependency _sqlDependency = new SqlDependency(_command);
            //_sqlDependency.OnChange += OnChangeEventHandler(OnChange);
            _sqlDependency.OnChange += OnChange;


            _adapter = new SqlDataAdapter(_command);
            _datable = new DataTable();
            _adapter.Fill(_datable);

            TablePro.DataSource = _datable;

        }
        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                TablePro.BeginInvoke(new MethodInvoker(FetchData));
            }
            else
            {
                FetchData();
            }
        }

        private void btnProsave_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("AddProduct", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Pname", txtPRoName.Text);
            _command.Parameters.AddWithValue("@Pqty", txtProQTY.Text);
            _command.Parameters.AddWithValue("@pps", txtProUnitPRice.Text);
            _command.Parameters.AddWithValue("@Psp", txtProSalePrice.Text);

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");
        }

        private void TablePro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = TablePro.Rows[i];
            txtProID.Text = row.Cells[0].Value.ToString();
            txtPRoName.Text = row.Cells[1].Value.ToString();
            txtProQTY.Text = row.Cells[2].Value.ToString();
            /////Cell[3]
            if (row.Cells[3].Value != null)
            {
                decimal unitPrice;
                if (decimal.TryParse(row.Cells[3].Value.ToString(), out unitPrice))
                {
                    txtProUnitPRice.Text = unitPrice.ToString();
                }
            }
            else
            {               
                MessageBox.Show("Unit Price is null");
            }
            /////cel[4]
            if (row.Cells[4].Value != null)
            {
                decimal salePrice;
                if (decimal.TryParse(row.Cells[4].Value.ToString(), out salePrice))
                {
                    txtProSalePrice.Text = salePrice.ToString();
                }
            }
            else
            {
                MessageBox.Show("Sale Price is null");
            }

        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("UpdateProduct", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Pname", txtPRoName.Text);
            _command.Parameters.AddWithValue("@Pqty", txtProQTY.Text);
            _command.Parameters.AddWithValue("@pps", txtProUnitPRice.Text);
            _command.Parameters.AddWithValue("@Psp", txtProSalePrice.Text);
            _command.Parameters.AddWithValue("@Pid", txtProID.Text);

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");
        }

        private void btnProdelete_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand("DeleteProduct", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Pid", txtProID.Text);
        

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");
        }

        private void btnProExit_Click(object sender, EventArgs e)
        {
            ContainerForm containerForm = new ContainerForm();
            containerForm.Show();
            this.Close();
        }
    }
}
