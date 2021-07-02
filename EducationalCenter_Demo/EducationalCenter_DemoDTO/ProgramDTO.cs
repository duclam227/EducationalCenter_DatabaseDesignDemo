using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter_DemoDTO
{
    public class ProgramDTO
    {
        private string _id;
        private string _name;
        private DateTime _startDate;

        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
    }
}
