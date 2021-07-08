using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationalCenter_DemoBUS;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_Demo
{
    public partial class EnrollClassWindow : Form
    {
        private readonly StudentDTO currentStudent;

        public EnrollClassWindow()
        {
            InitializeComponent();
        }

        public EnrollClassWindow(StudentDTO currentStudent)
        {
            InitializeComponent();
            this.currentStudent = currentStudent;
            string program = EducationalCenter_DemoBUS.StudentBUS.GetStudentProgram(currentStudent);
            //MessageBox.Show(program);
            EnrollClass_DataGridview.DataSource = EducationalCenter_DemoBUS.ClassBus.GetClass(currentStudent.ID, program);
        }
    

       
        private void EnrollClass_Submit_Click(object sender, EventArgs e)
        {
            string _regisID = "PDK05";
            //for (int i = 0; i <= EnrollClass_DataGridview.RowCount - 1; i++)
            //{
            //    bool checkedCell = (bool)EnrollClass_DataGridview.Rows[i].Cells[8].Value;
            //    if(checkedCell ==true)
            //    {

            //    }
            //}

            grv_ClassEnrollResult.DataSource = EducationalCenter_DemoBUS.RegistrationBUS.RegistrationDetail(_regisID);

        }
    }
}
