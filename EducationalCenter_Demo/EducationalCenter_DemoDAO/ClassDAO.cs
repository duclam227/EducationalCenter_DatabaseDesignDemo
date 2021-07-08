using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using EducationalCenter_DemoDTO;
using System.Windows.Forms;

namespace EducationalCenter_DemoDAO
{
    public class ClassDAO : DBConnect
    {
       public static DataTable GetClass(string _studentID, string _program)
        {
            
           DataTable result = new DataTable();

           string query = $"EXEC SHOWCLASS '{_studentID}', '{_program}'";

           SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
           adapter.Fill(result);
           return result;
        }
    }
}
