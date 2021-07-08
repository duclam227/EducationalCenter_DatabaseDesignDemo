using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenter_DemoDAO
{
    public class UserDAO : DBConnect
    {
        private static UserDAO _instance = null;
        public static UserDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserDAO();
                }
                return _instance;
            }
        }

        public static DataTable CheckUser(string username)
        {
            try
            {
                DataTable result = new DataTable();
                string query = $"select * from Users where username = '{username}'";

                _conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                adapter.Fill(result);
                _conn.Close();

                return result;
            }
            catch (Exception ex)
            {
                return null;
                _conn.Close();
            }

        }

        
    }
}
