using EducationalCenter_DemoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EducationalCenter_DemoDAO
{
    public class ScheduleDAO : DBConnect
    {
        public static void AddSchedule(ScheduleDTO newSchedule)
        {
            string command = $"insert into LICHTHI_MONHOC values ('{newSchedule.IDClass}'," +
                $"'{newSchedule.ExamType}'," +
                $"'{newSchedule.Date}', " +
                $"'{newSchedule.RoomID}'," +
                $"'{newSchedule.ShiftNumber}')";
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

        public static DataTable GetAll()
        {
            DataTable result = new DataTable();
            string command = "select * from LICHTHI_MONHOC";
            try
            {
                _conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, _conn);
                adapter.Fill(result);
                _conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static DataTable GetSchedule(string iDClass, string examType)
        {
            DataTable result = new DataTable();
            string command = $"select * from LICHTHI_MONHOC where MALOPHOC='{iDClass}' and PHANLOAI='{examType}' ";
            try
            {
                _conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, _conn);
                adapter.Fill(result);
                _conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
