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
    public partial class TuitionPaymentWindow : Form
    {
        private string username;
        private float _totalTuition;
        private string _MAPDK;

        public TuitionPaymentWindow()
        {
            InitializeComponent();
        }

        public TuitionPaymentWindow(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void TuitionPayment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MAHV = MaHocVien_TextBox.Text;
            string MAPDK = "";

            try
            {
                MAPDK = EducationalCenter_DemoBUS.RegistrationBUS.GetRegistrationID(MAHV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " hoặc mã học viên không hợp lệ");
                return;
            }

            if(MAPDK == null)
            {
                MessageBox.Show("Không có phiếu đăng ký ", MAPDK);
                return;
            }

            _MAPDK = MAPDK;

            float TONGHOCPHI = EducationalCenter_DemoBUS.TuitionPaymentBUS.getTotalTuition(MAPDK);
            _totalTuition = TONGHOCPHI;

            dataGridView_PDK.DataSource = EducationalCenter_DemoBUS.RegistrationBUS.RegistrationDetail(MAPDK);

            TongHocPhi_TextBox.Text = "Tổng học phí: " + _totalTuition;
        }

        private void XacNhanDongHocPhi_Button_Click(object sender, EventArgs e)
        {
            TuitionPaymentDTO newBill = new TuitionPaymentDTO();

            newBill.NGAYLAPHOADON = DateTime.Now.ToString("yyyy'-'MM'-'dd");
            newBill.MAPHIEUDANGKYLOPHOC = _MAPDK;
            newBill.TONGTIEN = _totalTuition;
            newBill.MANV = username;

            try
            {
                int isPosted = EducationalCenter_DemoBUS.TuitionPaymentBUS.postBill(newBill);

                if (isPosted == 1)
                {
                    MessageBox.Show("Đã thanh toán thành công");
                }
                else if (isPosted == 0)
                {
                    MessageBox.Show("Hóa đơn này đã thanh toán trước đó");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
