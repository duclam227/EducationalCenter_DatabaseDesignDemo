using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter_DemoDTO
{
    public class RegistrationDTO
    {
        private string _idSubject;
        private string _nameSubjet;
        private string _idClass;
        private DateTime _startTime;
        private string _room;
        private string _classDate;

        public string IDSub { get => _idSubject; set => _idSubject = value; }
        public string NameSub { get => _nameSubjet; set => _nameSubjet = value; }
        public string IDClass { get => _idClass; set => _idClass = value; }
        public DateTime StartDate { get => _startTime; set => _startTime = value; }
        public string Room { get => _room; set => _room = value; }
        public string ClassDate { get => _classDate; set => _classDate = value; }
    }
}
