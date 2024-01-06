using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DormitorySystem1
{
    public class SqlCon
    {
        public SqlConnection connect()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-50GA23PL;Initial Catalog=DormitaryRegistration;Integrated Security=True");
            connection.Open();
            return connection;
        }

    }
}
