using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter_DemoDTO
{
    public class SubjectDTO
    {
        private string _idSubject;
        private string _nameSubject;

        public string IDSub { get => _idSubject; set => _idSubject = value; }
        public string NameSub { get => _nameSubject; set => _nameSubject = value; }
    }
}
