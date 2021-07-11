using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoDAO
{
    public class SubjectDAO : DBConnect
    {
        public static DataTable GetAllSubjects()
        {
            DataTable result = new DataTable();
            string query = $"select * from MONHOC";


            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

     
    }
}
