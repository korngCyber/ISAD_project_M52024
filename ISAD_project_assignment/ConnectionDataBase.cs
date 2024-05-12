using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD_project_assignment
{
    public class ConnectionDataBase
    {
        public SqlConnection con;
        public string strConnection = "Data Source=DESKTOP-LD6E9JP\\DBSERVER;Initial Catalog=M52024;Integrated Security=True";
       // public string strConnection = "Data Source=.;Initial Catalog=M52024;Integrated Security=True;";
        public void myConnection()
        {
            SqlDependency.Stop(strConnection);
            SqlDependency.Start(strConnection);

            con= new SqlConnection(strConnection);  
            con.Open();
        }
    }
}
