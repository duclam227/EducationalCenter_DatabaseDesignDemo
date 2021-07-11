using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter_DemoDTO
{
    public class ScheduleDTO
    {
        private string _classID;
        private DateTime _date ;
        private string _examType;
        private string _roomID;
        private string _shiftNumber;

        public string IDClass { get => _classID; set => _classID = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string ExamType { get => _examType; set => _examType = value; }
        public string RoomID { get => _roomID; set => _roomID = value; }
        public string ShiftNumber { get => _shiftNumber; set => _shiftNumber = value; }
    }
}
