using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_Demo
{
    public partial class EnrolStudentWindow : Form
    {
        public EnrolStudentWindow()
        {
            InitializeComponent();

            try
            {
                ProgramComboBox.DataSource = EducationalCenter_DemoBUS.ProgramBUS.GetAvailablePrograms();
                ProgramComboBox.DisplayMember = "Name";
                ProgramComboBox.ValueMember = "ID";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnrolButton_Click(object sender, EventArgs e)
        {
            string programID;

            programID = ProgramComboBox.SelectedValue.ToString();

            StudentDTO newStudent = new StudentDTO();
            newStudent.Name = NameTextBox.Text;
            newStudent.Address = AddressTextBox.Text;
            newStudent.Phone = PhoneTextBox.Text;
            newStudent.DOB = BirthdayPicker.Value;

            if(newStudent.Name.Length == 0 || newStudent.Address.Length == 0 || newStudent.Phone.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }
            try
            {
                int check = EducationalCenter_DemoBUS.StudentBUS.CheckExist(newStudent);

                switch (check)
                {
                    case 0:
                        {
                            //insert học viên
                            EducationalCenter_DemoBUS.StudentBUS.AddStudent(newStudent);
                            //insert ghi danh
                            EducationalCenter_DemoBUS.ProgramBUS.EnrolStudent(newStudent, programID);
                            break;
                        }
                    case 1:
                        {
                            //kiểm tra đăng ký ctdt này chưa
                            newStudent.ID = EducationalCenter_DemoBUS.StudentBUS.GetID(newStudent);
                            int checkProgram = EducationalCenter_DemoBUS.StudentBUS.CheckExist(newStudent, programID);
                            if(checkProgram == 0)
                            {
                                //insert ghi danh
                                EducationalCenter_DemoBUS.ProgramBUS.EnrolStudent(newStudent, programID);
                            }
                            else
                            {
                                MessageBox.Show($"Học viên {newStudent.Name} đã đăng ký khóa học này rồi!");
                                return;
                            }
                            break;
                        }
                }

                MessageBox.Show("Đăng ký thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}
