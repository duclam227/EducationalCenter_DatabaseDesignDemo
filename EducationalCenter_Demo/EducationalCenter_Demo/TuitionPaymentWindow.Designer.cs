
namespace EducationalCenter_Demo
{
    partial class TuitionPaymentWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MaHocVien_TextBox = new System.Windows.Forms.TextBox();
            this.MaHocVien_Lable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_PDK = new System.Windows.Forms.DataGridView();
            this.TongHocPhi_TextBox = new System.Windows.Forms.Label();
            this.XacNhanDongHocPhi_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PDK)).BeginInit();
            this.SuspendLayout();
            // 
            // MaHocVien_TextBox
            // 
            this.MaHocVien_TextBox.Location = new System.Drawing.Point(106, 16);
            this.MaHocVien_TextBox.MinimumSize = new System.Drawing.Size(178, 22);
            this.MaHocVien_TextBox.Name = "MaHocVien_TextBox";
            this.MaHocVien_TextBox.Size = new System.Drawing.Size(178, 22);
            this.MaHocVien_TextBox.TabIndex = 0;
            // 
            // MaHocVien_Lable
            // 
            this.MaHocVien_Lable.AutoSize = true;
            this.MaHocVien_Lable.Location = new System.Drawing.Point(12, 19);
            this.MaHocVien_Lable.Name = "MaHocVien_Lable";
            this.MaHocVien_Lable.Size = new System.Drawing.Size(84, 17);
            this.MaHocVien_Lable.TabIndex = 1;
            this.MaHocVien_Lable.Text = "Mã học viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm phiếu đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_PDK
            // 
            this.dataGridView_PDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PDK.Location = new System.Drawing.Point(12, 49);
            this.dataGridView_PDK.Name = "dataGridView_PDK";
            this.dataGridView_PDK.RowHeadersWidth = 51;
            this.dataGridView_PDK.RowTemplate.Height = 24;
            this.dataGridView_PDK.Size = new System.Drawing.Size(958, 143);
            this.dataGridView_PDK.TabIndex = 3;
            // 
            // TongHocPhi_TextBox
            // 
            this.TongHocPhi_TextBox.AutoSize = true;
            this.TongHocPhi_TextBox.Location = new System.Drawing.Point(12, 212);
            this.TongHocPhi_TextBox.Name = "TongHocPhi_TextBox";
            this.TongHocPhi_TextBox.Size = new System.Drawing.Size(99, 17);
            this.TongHocPhi_TextBox.TabIndex = 4;
            this.TongHocPhi_TextBox.Text = "Tổng học phí: ";
            // 
            // XacNhanDongHocPhi_Button
            // 
            this.XacNhanDongHocPhi_Button.Location = new System.Drawing.Point(851, 206);
            this.XacNhanDongHocPhi_Button.Name = "XacNhanDongHocPhi_Button";
            this.XacNhanDongHocPhi_Button.Size = new System.Drawing.Size(119, 28);
            this.XacNhanDongHocPhi_Button.TabIndex = 5;
            this.XacNhanDongHocPhi_Button.Text = "Xác nhận";
            this.XacNhanDongHocPhi_Button.UseVisualStyleBackColor = true;
            this.XacNhanDongHocPhi_Button.Click += new System.EventHandler(this.XacNhanDongHocPhi_Button_Click);
            // 
            // TuitionPaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 253);
            this.Controls.Add(this.XacNhanDongHocPhi_Button);
            this.Controls.Add(this.TongHocPhi_TextBox);
            this.Controls.Add(this.dataGridView_PDK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaHocVien_Lable);
            this.Controls.Add(this.MaHocVien_TextBox);
            this.Name = "TuitionPaymentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh Toán Học Phí";
            this.Load += new System.EventHandler(this.TuitionPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaHocVien_TextBox;
        private System.Windows.Forms.Label MaHocVien_Lable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_PDK;
        private System.Windows.Forms.Label TongHocPhi_TextBox;
        private System.Windows.Forms.Button XacNhanDongHocPhi_Button;
    }
}