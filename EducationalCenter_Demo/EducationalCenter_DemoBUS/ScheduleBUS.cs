using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoBUS
{
    public class ScheduleBUS
    {
        public static void AddSchedule (ScheduleDTO newSchedule)
        {
            EducationalCenter_DemoDAO.ScheduleDAO.AddSchedule(newSchedule);                           
        }
    }
}
