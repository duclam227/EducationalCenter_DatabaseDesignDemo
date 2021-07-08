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
    public partial class ForgotPasswordWindow : Form
    {
        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập email!");
                return;
            }

            MessageBox.Show("Một email đã được gửi đến địa chỉ của bạn.");
            return;
        }
    }
}
