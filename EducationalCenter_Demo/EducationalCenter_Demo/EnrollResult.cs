using EducationalCenter_DemoDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalCenter_Demo
{
    public partial class EnrollResult : Form
    {
        private StudentDTO currentStudent;

        public EnrollResult()
        {
            InitializeComponent();
        }

        public EnrollResult(StudentDTO currentStudent)
        {
            InitializeComponent();
            this.currentStudent = currentStudent;
            string _regisID = EducationalCenter_DemoBUS.RegistrationBUS.GetRegistrationID(currentStudent.ID);
            grv_EnrollResult.DataSource = EducationalCenter_DemoBUS.RegistrationBUS.RegistrationDetail(_regisID);
        }
    }
}
