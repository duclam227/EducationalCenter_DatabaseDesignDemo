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

            string _regisID = EducationalCenter_DemoBUS.RegistrationBUS.GetRegistrationID(currentStudent.ID);

            EnrollClass_DataGridview.DataSource = EducationalCenter_DemoBUS.ClassBus.GetClass(currentStudent.ID, program);


            grv_ClassEnrollResult.DataSource = EducationalCenter_DemoBUS.RegistrationBUS.RegistrationDetail(_regisID);
        }
    

       
        private void EnrollClass_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string program = EducationalCenter_DemoBUS.StudentBUS.GetStudentProgram(currentStudent);
                string _regisID = EducationalCenter_DemoBUS.RegistrationBUS.GetRegistrationID(currentStudent.ID);
                if (_regisID == null)
                {
                    _regisID = EducationalCenter_DemoBUS.RegistrationBUS.CreateRegis(currentStudent.ID);

                }

                for (int i = 0; i <= EnrollClass_DataGridview.RowCount - 1; i++)
                {
                    int CheckEnroll;
                    bool checkedCell = (bool)EnrollClass_DataGridview.Rows[i].Cells[8].Value;
                    string _idClass = (string)EnrollClass_DataGridview.Rows[i].Cells[2].Value;
                    string _idSub = (string)EnrollClass_DataGridview.Rows[i].Cells[0].Value;

                    //Enroll Class
                    if (checkedCell == true)
                    {

                        //CheckEnroll
                        //If enrolled, pass. If not, enroll
                        CheckEnroll = EducationalCenter_DemoBUS.RegistrationBUS.CheckRegisClass(_regisID, _idClass);

                        //Not enroll
                        //Check whether student enroll this subject or not
                        //If yes, deny. If no, accept
                        if (CheckEnroll == 0)
                        {
                            int CheckSub = EducationalCenter_DemoBUS.RegistrationBUS.CheckRegisSubject(_regisID, _idSub);

                            if (CheckSub == 1)
                                MessageBox.Show("Không thể đăng ký lớp " + _idClass + " vì môn này đã được đăng ký");
                            else
                            {
                                
                                    EducationalCenter_DemoBUS.ClassBus.EnrollClass(_regisID, _idClass);
                                
                                
                            }
                        }
                    }
                    else
                    {
                        //CheckEnroll
                        //If enrolled, delete. If not, pass
                        CheckEnroll = EducationalCenter_DemoBUS.RegistrationBUS.CheckRegisClass(_regisID, _idClass);

                        if (CheckEnroll == 1)
                        {
                            
                                EducationalCenter_DemoBUS.ClassBus.CancelClass(_regisID, _idClass);
                            
                           
                        }

                        //MessageBox.Show(CheckEnroll.ToString());
                    }
                }

                MessageBox.Show("Xác nhận đăng ký");
                grv_ClassEnrollResult.DataSource = EducationalCenter_DemoBUS.RegistrationBUS.RegistrationDetail(_regisID);
                EnrollClass_DataGridview.DataSource = EducationalCenter_DemoBUS.ClassBus.GetClass(currentStudent.ID, program);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
