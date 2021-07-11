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

    }
}
