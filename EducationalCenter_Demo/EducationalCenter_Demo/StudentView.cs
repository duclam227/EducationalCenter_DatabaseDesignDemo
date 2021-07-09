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
    public partial class StudentView : Form
    {
        private StudentDTO currentStudent;

        public StudentView()
        {
            InitializeComponent();
        }

        public StudentView(StudentDTO currentStudent)
        {
            InitializeComponent();
            this.currentStudent = currentStudent;
        }

        private void EnrollClass_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollClassWindow enrol = new EnrollClassWindow (currentStudent);
            enrol.ShowDialog(this);
            this.Show();
            return;
        }

        private void SeeResult_button_Click(object sender, EventArgs e)
        {
            this.Hide();
           EnrollResult enrol = new EnrollResult(currentStudent);
            enrol.ShowDialog(this);
            this.Show();
            return;
        }
    }
}
