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

namespace EducationalCenter_Demo
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username, password;
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin đăng nhập!");
                return;
            }

            this.Hide();
            EnrolStudentWindow enrol = new EnrolStudentWindow();
            enrol.ShowDialog(this);
            this.Show();

            //try
            //{
            //    int userCheck = EducationalCenter_DemoBUS.UserBUS.CheckUser(username, password);
            //    switch (userCheck)
            //    {
            //        case -1:
            //            {
            //                MessageBox.Show("Sai mật khẩu!");
            //                return;
            //            }
            //        case 0:
            //            {
            //                MessageBox.Show("Không tồn tại tài khoản!");
            //                return;
            //            }
            //        case 1:
            //            {
            //                MessageBox.Show("Đăng nhập thành công!");
            //                //show màn hình
            //                return;
            //            }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ForgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordWindow forgot = new ForgotPasswordWindow();
            forgot.ShowDialog(this);
            this.Show();
        }
    }
}
