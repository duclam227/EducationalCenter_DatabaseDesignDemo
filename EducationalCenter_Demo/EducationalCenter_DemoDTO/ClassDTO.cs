using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter_DemoDTO
{
    public class ClassDTO
    {
        private string _idSubject;
        private string _nameSubjet;
        private string _idClass;
        private DateTime _startTime;
        private string _room;
        private string _classDate;
        private string _max;
        private string _current;
        private bool _checkbox;

        public string IDSub { get => _idSubject; set => _idSubject = value; }
        public string NameSub { get => _nameSubjet; set => _nameSubjet = value; }
        public string IDClass { get => _idClass; set => _idClass = value; }
        public DateTime StartDate { get => _startTime; set => _startTime = value; }
        //public DateTime EndDate { get => _endTime; set => _endTime = value; }
        public string Room { get => _room; set => _room = value; }
        public string ClassDate { get => _classDate; set => _classDate = value; }
        public string MaxNumber { get => _max; set => _max = value; }
        public string CurrentNumber { get => _current; set => _current = value; }
        public bool Enroll { get => _checkbox; set => _checkbox = value; }
    }
}