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
    public partial class ExamScheduleForm : Form
    {
        public ExamScheduleForm()
        {
            InitializeComponent();

            try
            {
                //lấy lịch thi
                ScheduleDataGridView.DataSource = EducationalCenter_DemoBUS.ScheduleBUS.GetAll();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ScheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
