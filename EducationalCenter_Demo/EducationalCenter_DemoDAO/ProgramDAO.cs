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
    public class ProgramDAO : DBConnect
    {
        public static DataTable GetAllPrograms()
        {
            DataTable result = new DataTable();

            string query = $"select * from CT_DAOTAO";

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

        public static void EnrolStudent(StudentDTO newStudent, string program)
        {
            string command = $"insert into GHIDANH " +
                $"values('{program}', '{newStudent.ID}', '{DateTime.Today}')";

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(command, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception ex)
            {
                //_conn.Close();
                throw ex;
            }

        }
    }
}
