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

        public static void EnrollClass(string _regisID, string _classID)
        {
            try
            {
                string command = $"EXEC ENROLL_CLASS '{_classID}', '{_regisID}'";

                _conn.Open();
                SqlCommand cmd = new SqlCommand(command, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception)
            {
                _conn.Close();
            }
        }


        public static DataTable GetAllClasses(string _subjectID)
        {
            DataTable result = new DataTable();
            string query = $"select * from LOPHOC WHERE MAMH = '{_subjectID}'";


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


    

        public static void CancelClass (string _regisID, string _classID)
            {
                try
                {
                    string command = $"EXEC CANCEL_CLASS '{_regisID}', '{_classID}'";

                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(command, _conn);
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                }
                catch (Exception)
                {
                    _conn.Close();
                }
            }
        }
}
