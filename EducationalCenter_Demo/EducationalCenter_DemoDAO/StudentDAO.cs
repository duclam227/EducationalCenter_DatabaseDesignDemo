using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoDAO
{
    public class StudentDAO : DBConnect
    {
        public static DataTable CheckExist(StudentDTO student)
        {
            DataTable result = new DataTable();

            try
            {
                string query = $"select count(*) as ketqua from HOCVIEN " +
                               $"where TENHV = N'{student.Name}'" +
                               $" and DOB_HV = '{student.DOB}' and DIACHI_HV = N'{student.Address}'";

                try
                {
                    _conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                    adapter.Fill(result);
                    _conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           

            return result;
        }

        public static DataTable CheckExist(StudentDTO student, string program)
        {
            DataTable result = new DataTable();

            try
            {
                string query = $"select count(*) as ketqua from GHIDANH " +
                    $"where MAHV = '{student.ID}' and MACTDT = '{program}'";

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                    adapter.Fill(result);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static DataTable GetID(StudentDTO student)
        {
            DataTable result = new DataTable();

            try
            {
                string query = $"select MAHV as ketqua from HOCVIEN " +
                    $"where TENHV = N'{student.Name}' and DOB_HV = '{student.DOB}' " +
                    $"and DIACHI_HV = N'{student.Address}'";

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                    adapter.Fill(result);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;
        }

        public static void AddStudent(StudentDTO newStudent)
        {
            string command = $"insert into HOCVIEN " +
                $"values('{newStudent.ID}', N'{newStudent.Name}', '{newStudent.DOB}', N'{newStudent.Address}', '{newStudent.Phone}', '{newStudent.ID}')";


            try
            {
                _conn.Open();
                SqlCommand cmd_a = new SqlCommand(command, _conn);
                cmd_a.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable GetStudentAmount()
        {
            DataTable result = new DataTable();

            try
            {
                string query = $"select count(*) as ketqua from HOCVIEN";

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                    adapter.Fill(result);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;
        }
    }
}
