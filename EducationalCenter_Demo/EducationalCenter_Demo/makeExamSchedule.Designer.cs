
namespace EducationalCenter_Demo
{
    partial class makeExamSchedule
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
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveSchedule = new System.Windows.Forms.Button();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textRoom = new System.Windows.Forms.TextBox();
            this.GK = new System.Windows.Forms.RadioButton();
            this.CK = new System.Windows.Forms.RadioButton();
            this.ca1 = new System.Windows.Forms.RadioButton();
            this.ca2 = new System.Windows.Forms.RadioButton();
            this.ca3 = new System.Windows.Forms.RadioButton();
            this.ca4 = new System.Windows.Forms.RadioButton();
            this.loaiThi = new System.Windows.Forms.GroupBox();
            this.caThi = new System.Windows.Forms.GroupBox();
            this.loaiThi.SuspendLayout();
            this.caThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboSubject
            // 
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(16, 57);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(108, 21);
            this.comboSubject.TabIndex = 0;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn ngày thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập phòng:";
            // 
            // saveSchedule
            // 
            this.saveSchedule.Location = new System.Drawing.Point(69, 482);
            this.saveSchedule.Name = "saveSchedule";
            this.saveSchedule.Size = new System.Drawing.Size(75, 23);
            this.saveSchedule.TabIndex = 5;
            this.saveSchedule.Text = "Lên lịch thi";
            this.saveSchedule.UseVisualStyleBackColor = true;
            this.saveSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(16, 118);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(108, 21);
            this.comboClass.TabIndex = 6;
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(16, 172);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // textRoom
            // 
            this.textRoom.Location = new System.Drawing.Point(16, 306);
            this.textRoom.Name = "textRoom";
            this.textRoom.Size = new System.Drawing.Size(108, 20);
            this.textRoom.TabIndex = 8;
            // 
            // GK
            // 
            this.GK.AutoSize = true;
            this.GK.Checked = true;
            this.GK.Location = new System.Drawing.Point(6, 26);
            this.GK.Name = "GK";
            this.GK.Size = new System.Drawing.Size(58, 17);
            this.GK.TabIndex = 9;
            this.GK.TabStop = true;
            this.GK.Text = "Giữa kì";
            this.GK.UseVisualStyleBackColor = true;
            // 
            // CK
            // 
            this.CK.AutoSize = true;
            this.CK.Location = new System.Drawing.Point(121, 26);
            this.CK.Name = "CK";
            this.CK.Size = new System.Drawing.Size(57, 17);
            this.CK.TabIndex = 10;
            this.CK.Text = "Cuối kì";
            this.CK.UseVisualStyleBackColor = true;
            // 
            // ca1
            // 
            this.ca1.AutoSize = true;
            this.ca1.Checked = true;
            this.ca1.Location = new System.Drawing.Point(15, 19);
            this.ca1.Name = "ca1";
            this.ca1.Size = new System.Drawing.Size(47, 17);
            this.ca1.TabIndex = 14;
            this.ca1.TabStop = true;
            this.ca1.Text = "Ca 1";
            this.ca1.UseVisualStyleBackColor = true;
            // 
            // ca2
            // 
            this.ca2.AutoSize = true;
            this.ca2.Location = new System.Drawing.Point(15, 42);
            this.ca2.Name = "ca2";
            this.ca2.Size = new System.Drawing.Size(47, 17);
            this.ca2.TabIndex = 15;
            this.ca2.Text = "Ca 2";
            this.ca2.UseVisualStyleBackColor = true;
            // 
            // ca3
            // 
            this.ca3.AutoSize = true;
            this.ca3.Location = new System.Drawing.Point(15, 65);
            this.ca3.Name = "ca3";
            this.ca3.Size = new System.Drawing.Size(47, 17);
            this.ca3.TabIndex = 16;
            this.ca3.Text = "Ca 3";
            this.ca3.UseVisualStyleBackColor = true;
            // 
            // ca4
            // 
            this.ca4.AutoSize = true;
            this.ca4.Location = new System.Drawing.Point(15, 88);
            this.ca4.Name = "ca4";
            this.ca4.Size = new System.Drawing.Size(47, 17);
            this.ca4.TabIndex = 17;
            this.ca4.Text = "Ca 4";
            this.ca4.UseVisualStyleBackColor = true;
            // 
            // loaiThi
            // 
            this.loaiThi.Controls.Add(this.CK);
            this.loaiThi.Controls.Add(this.GK);
            this.loaiThi.Location = new System.Drawing.Point(16, 214);
            this.loaiThi.Name = "loaiThi";
            this.loaiThi.Size = new System.Drawing.Size(197, 62);
            this.loaiThi.TabIndex = 18;
            this.loaiThi.TabStop = false;
            this.loaiThi.Text = "Loại";
            // 
            // caThi
            // 
            this.caThi.Controls.Add(this.ca1);
            this.caThi.Controls.Add(this.ca2);
            this.caThi.Controls.Add(this.ca4);
            this.caThi.Controls.Add(this.ca3);
            this.caThi.Location = new System.Drawing.Point(16, 342);
            this.caThi.Name = "caThi";
            this.caThi.Size = new System.Drawing.Size(200, 119);
            this.caThi.TabIndex = 19;
            this.caThi.TabStop = false;
            this.caThi.Text = "Chọn ca thi";
            // 
            // makeExamSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 556);
            this.Controls.Add(this.caThi);
            this.Controls.Add(this.loaiThi);
            this.Controls.Add(this.textRoom);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.saveSchedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSubject);
            this.Name = "makeExamSchedule";
            this.Text = "Lên lịch thi";
            this.Load += new System.EventHandler(this.makeExamSchedule_Load);
            this.loaiThi.ResumeLayout(false);
            this.loaiThi.PerformLayout();
            this.caThi.ResumeLayout(false);
            this.caThi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveSchedule;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textRoom;
        private System.Windows.Forms.RadioButton GK;
        private System.Windows.Forms.RadioButton CK;
        private System.Windows.Forms.RadioButton ca1;
        private System.Windows.Forms.RadioButton ca2;
        private System.Windows.Forms.RadioButton ca3;
        private System.Windows.Forms.RadioButton ca4;
        private System.Windows.Forms.GroupBox loaiThi;
        private System.Windows.Forms.GroupBox caThi;
    }
}