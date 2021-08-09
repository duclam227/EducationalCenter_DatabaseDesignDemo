using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoBUS
{
    public class ScheduleBUS
    {
        public static void AddSchedule (ScheduleDTO newSchedule)
        {

            EducationalCenter_DemoDAO.ScheduleDAO.AddSchedule(newSchedule);                           
        }

        public static List<ScheduleDTO> GetAll()
        {
            List<ScheduleDTO> result = new List<ScheduleDTO>();

            try
            {
               DataTable dt = EducationalCenter_DemoDAO.ScheduleDAO.GetAll();
                foreach (DataRow row in dt.Rows)
                {
                    ScheduleDTO tmp = new ScheduleDTO();
                    tmp.IDClass = row["MALOPHOC"].ToString();
                    tmp.ExamType = row["PHANLOAI"].ToString();
                    tmp.RoomID = row["PHONGTHI_MONHOC"].ToString();
                    tmp.ShiftNumber = row["CATHI_MONHOC"].ToString();
                    string tmpDate = row["NGAYTHI_MONHOC"].ToString();
                    tmp.Date = DateTime.Parse(tmpDate);

                    result.Add(tmp);
                }

            } 
            catch(Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static bool checkExistedSchedule(string iDClass, string examType)
        {
            DataTable schedule = EducationalCenter_DemoDAO.ScheduleDAO.GetSchedule(iDClass, examType);

            if (schedule == null || schedule.Rows.Count == 0)
                return false;

            return true;
        }
    }
}
