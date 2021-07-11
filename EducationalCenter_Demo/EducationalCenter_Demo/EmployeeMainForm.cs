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
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
        }

        private void EnrolButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrolStudentWindow enrol = new EnrolStudentWindow();
            enrol.ShowDialog(this);
            this.Show();
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            makeExamSchedule schedule = new makeExamSchedule();
            schedule.ShowDialog(this);
            this.Show();
        }
    }
}
