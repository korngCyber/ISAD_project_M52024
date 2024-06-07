using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD_project_assignment
{
    public partial class StaffForm : Form
    {
        ConnectionDataBase _connectDatabase = new ConnectionDataBase();
        SqlCommand _command;
        SqlDataAdapter _adapter;
        DataTable _datable;
        public StaffForm()
        {
            _connectDatabase.myConnection();
            InitializeComponent();
            FetchData();
              
        }
        private void clearTxt()
        {
            txtStaID.Text = "";
            txtStaName.Text = "";
            txtGender.Text = "";
            txtStaSlary.Text = "";
            comboStaPos.SelectedIndex= -1;
            comboStaDOB.Text = "";
            checkStaWork.Checked = false;
            btnStaMale.Checked = false;
            btnStaFemale.Checked = false;  
          
        }
        private Image GetImage(byte[] img)
        {
            MemoryStream stream = new MemoryStream(img);
            return Image.FromStream(stream);

        }
        public void FetchData()
        {
            try
            {
                _command = new SqlCommand("fetchStaff", _connectDatabase.con);
                _command.CommandType = CommandType.StoredProcedure;

                SqlDependency _sqlDependency = new SqlDependency(_command);
                _sqlDependency.OnChange += OnChange;

                _adapter = new SqlDataAdapter(_command);
                _datable = new DataTable();
                _adapter.Fill(_datable);
                TableSta.DataSource = _datable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

     

        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                TableSta.BeginInvoke(new MethodInvoker(FetchData));
            }
            else
            {
                FetchData();
            }
        }

        private void TabelSup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = TableSta.Rows[i];
            txtStaID.Text = row.Cells[0].Value.ToString();
            txtStaName.Text = row.Cells[1].Value.ToString();
            ////Cell[2]
            /* if ((char)row.Cells[2].Value == 'M')
             {
                 btnStaMale.Enabled = true;
             }
             else
             {
                 btnStaFemale.Enabled = true;
             }*/
            if (row.Cells[2].Value.ToString() == "M")
            {
                txtGender.Text = 'M'.ToString();
            }
            else
            {
                txtGender.Text = 'F'.ToString();
            }
            comboStaDOB.Text = row.Cells[3].Value.ToString();
            comboStaPos.Text = row.Cells[4].Value.ToString(); 
            /////Cell[5]
            if (row.Cells[5].Value != null)
            {
                decimal salary;
                if (decimal.TryParse(row.Cells[5].Value.ToString(), out salary))
                {
                    txtStaSlary.Text = salary.ToString();
                }
            }
            else
            {
                MessageBox.Show("Unit Price is null");
            }
            ////cell[6]
            if ((bool)row.Cells[6].Value == true)
            {
                checkStaWork.Checked = true;
            }
            else
            {
                checkStaWork.Checked = false;
            }
            // checkStaWork.Checked = (bool)row.Cells[6].Value;
            //cell[7] 
          




        }

        private void btnStasave_Click(object sender, EventArgs e)
        {
            Boolean stopwork;
        
            _command = new SqlCommand("AddStaff", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Sname", txtStaName.Text);
            if (btnStaMale.Checked)
            {
                txtGender.Text = 'M'.ToString();
            }
            if(btnStaFemale.Checked)
            {
                txtGender.Text = 'F'.ToString();
            }
            _command.Parameters.AddWithValue("@Sgen", txtGender.Text);
            _command.Parameters.AddWithValue("@Sdob", comboStaDOB.Value);
            _command.Parameters.AddWithValue("@Spo", comboStaPos.Text);
            _command.Parameters.AddWithValue("@Ssa", txtStaSlary.Text);

            if(checkStaWork.Checked) 
            { 
                stopwork = true;
            }else { 
                stopwork = false; 
            }   
            _command.Parameters.AddWithValue("@Ssw", stopwork);
    

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");
        }

        private void btnStaDelete_Click(object sender, EventArgs e)
        {
            Boolean stopwork;
            _command = new SqlCommand("DeleteStaff", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Sid", txtStaID.Text);

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");

        }

        private void btnStaupdate_Click(object sender, EventArgs e)
        {
            Boolean stopwork;
           
            _command = new SqlCommand("UpdateStaff", _connectDatabase.con);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Sname", txtStaName.Text);
            if (btnStaMale.Checked)
            {
                txtGender.Text = 'M'.ToString();
            }
            if (btnStaFemale.Checked)
            {
                txtGender.Text = 'F'.ToString();
            }
            _command.Parameters.AddWithValue("@Sgen", txtGender.Text);
            _command.Parameters.AddWithValue("@Sdob", comboStaDOB.Value);
            _command.Parameters.AddWithValue("@Spo", comboStaPos.Text);
            _command.Parameters.AddWithValue("@Ssa", txtStaSlary.Text);
            _command.Parameters.AddWithValue("@Sid", txtStaID.Text);
         
            if (checkStaWork.Checked)
            {
                stopwork = true;
            }
            else
            {
                stopwork = false;
            }
            _command.Parameters.AddWithValue("@Ssw", stopwork);

            _command.ExecuteNonQuery();
            clearTxt();
            MessageBox.Show("Data Stored....!");

        }

        private void btnstaExit_Click(object sender, EventArgs e)
        {
            ContainerForm containerForm = new ContainerForm();
            containerForm.Show();
            this.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (TableSta.DataSource is DataTable dataTable)
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
