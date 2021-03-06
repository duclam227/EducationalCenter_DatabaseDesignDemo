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
    public partial class makeExamSchedule : Form
    {
        public makeExamSchedule()
        {
            InitializeComponent();
            comboSubject.DataSource = EducationalCenter_DemoBUS.SubjectBUS.GetAllSubjects();
            comboSubject.DisplayMember = "NameSub";
            comboSubject.ValueMember = "IDSub";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScheduleDTO newSchedule = new ScheduleDTO();
            string _classID = "";
            DateTime _date = dateTimePicker.Value;
            string _examType = (GK.Checked ? "GK" : "CK");
            string _roomID = textRoom.Text;
            string _shiftNumber = "";


            if (ca1.Checked)
                _shiftNumber = "Ca 1";
            if (ca2.Checked)
                _shiftNumber = "Ca 2";
            if (ca3.Checked)
                _shiftNumber = "Ca 3";
            if (ca4.Checked)
                _shiftNumber = "Ca 4";


            if (textRoom.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên phòng");
                return;
            }



            if ( comboClass.SelectedValue == null ||  comboClass.SelectedValue.ToString().Length == 0 )
            {
                MessageBox.Show("Bạn chưa chọn lớp");
                return;
            }

            _classID = comboClass.SelectedValue.ToString();


            newSchedule.IDClass = _classID;
            newSchedule.Date = _date;
            newSchedule.ExamType = _examType;
            newSchedule.RoomID = _roomID;
            newSchedule.ShiftNumber = _shiftNumber;

            bool existedSchedule = EducationalCenter_DemoBUS.ScheduleBUS.checkExistedSchedule(newSchedule.IDClass, newSchedule.ExamType);

            if (existedSchedule)
            {
                MessageBox.Show("Lịch thi đã tồn tại");
                return;
            }
            try
            {
                EducationalCenter_DemoBUS.ScheduleBUS.AddSchedule(newSchedule);
                MessageBox.Show("Thành công!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboClass.DataSource = null;
            string _subjectID = comboSubject.SelectedValue.ToString();
            comboClass.DataSource = EducationalCenter_DemoBUS.ClassBus.GetAllClasses(_subjectID);
            comboClass.DisplayMember = "IDClass";
            comboClass.ValueMember = "IDClass";
        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void makeExamSchedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExamScheduleForm schedule = new ExamScheduleForm();
            schedule.Show();
        }
    }
}
