using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter_DemoDTO
{
    public class StudentDTO
    {
        private string _id;
        private string _name;
        private DateTime _dob;
        private string _address;
        private string _phone;

        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime DOB { get => _dob; set => _dob = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }

    }
}
