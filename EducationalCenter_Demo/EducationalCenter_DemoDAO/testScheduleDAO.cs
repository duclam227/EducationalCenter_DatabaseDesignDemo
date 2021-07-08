using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter_DemoDAO
{
    public class testScheduleDAO : DBConnect
    {
        private string _id;
        private string _name;
        private DateTime _testDay;
        private string _address;
        private string _phone;

        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime TestDay { get => _testDay; set => _testDay = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}
