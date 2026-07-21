using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Company_Support_Program
{
    internal class DatabaseConnection
    {
        private SqlConnection connect= 
            new SqlConnection("Data Source=localhost;Initial Catalog=CompanySupport;Integrated Security=True");

        public SqlConnection GetConnection()
        {
            return connect;
        }
        
    }
}
