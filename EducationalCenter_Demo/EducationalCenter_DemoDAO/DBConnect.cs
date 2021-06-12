using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EducationalCenter_DemoDAO
{
    public class DBConnect
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        protected SqlConnection _conn = new SqlConnection(connectionString);
    }
}
