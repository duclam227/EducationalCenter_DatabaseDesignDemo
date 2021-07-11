
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
            this.button1 = new System.Windows.Forms.Button();
            this.loaiThi.SuspendLayout();
            this.caThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboSubject
            // 
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(124, 22);
            this.comboSubject.Margin = new System.Windows.Forms.Padding(4);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(248, 24);
            this.comboSubject.TabIndex = 0;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn ngày thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập phòng:";
            // 
            // saveSchedule
            // 
            this.saveSchedule.Location = new System.Drawing.Point(601, 205);
            this.saveSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.saveSchedule.Name = "saveSchedule";
            this.saveSchedule.Size = new System.Drawing.Size(100, 35);
            this.saveSchedule.TabIndex = 5;
            this.saveSchedule.Text = "Lên lịch thi";
            this.saveSchedule.UseVisualStyleBackColor = true;
            this.saveSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(124, 72);
            this.comboClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(248, 24);
            this.comboClass.TabIndex = 6;
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(124, 122);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker.TabIndex = 7;
            // 
            // textRoom
            // 
            this.textRoom.Location = new System.Drawing.Point(124, 170);
            this.textRoom.Margin = new System.Windows.Forms.Padding(4);
            this.textRoom.Name = "textRoom";
            this.textRoom.Size = new System.Drawing.Size(248, 22);
            this.textRoom.TabIndex = 8;
            // 
            // GK
            // 
            this.GK.AutoSize = true;
            this.GK.Checked = true;
            this.GK.Location = new System.Drawing.Point(20, 23);
            this.GK.Margin = new System.Windows.Forms.Padding(4);
            this.GK.Name = "GK";
            this.GK.Size = new System.Drawing.Size(73, 21);
            this.GK.TabIndex = 9;
            this.GK.TabStop = true;
            this.GK.Text = "Giữa kì";
            this.GK.UseVisualStyleBackColor = true;
            // 
            // CK
            // 
            this.CK.AutoSize = true;
            this.CK.Location = new System.Drawing.Point(201, 23);
            this.CK.Margin = new System.Windows.Forms.Padding(4);
            this.CK.Name = "CK";
            this.CK.Size = new System.Drawing.Size(71, 21);
            this.CK.TabIndex = 10;
            this.CK.Text = "Cuối kì";
            this.CK.UseVisualStyleBackColor = true;
            // 
            // ca1
            // 
            this.ca1.AutoSize = true;
            this.ca1.Checked = true;
            this.ca1.Location = new System.Drawing.Point(20, 34);
            this.ca1.Margin = new System.Windows.Forms.Padding(4);
            this.ca1.Name = "ca1";
            this.ca1.Size = new System.Drawing.Size(58, 21);
            this.ca1.TabIndex = 14;
            this.ca1.TabStop = true;
            this.ca1.Text = "Ca 1";
            this.ca1.UseVisualStyleBackColor = true;
            // 
            // ca2
            // 
            this.ca2.AutoSize = true;
            this.ca2.Location = new System.Drawing.Point(201, 34);
            this.ca2.Margin = new System.Windows.Forms.Padding(4);
            this.ca2.Name = "ca2";
            this.ca2.Size = new System.Drawing.Size(58, 21);
            this.ca2.TabIndex = 15;
            this.ca2.Text = "Ca 2";
            this.ca2.UseVisualStyleBackColor = true;
            // 
            // ca3
            // 
            this.ca3.AutoSize = true;
            this.ca3.Location = new System.Drawing.Point(20, 63);
            this.ca3.Margin = new System.Windows.Forms.Padding(4);
            this.ca3.Name = "ca3";
            this.ca3.Size = new System.Drawing.Size(58, 21);
            this.ca3.TabIndex = 16;
            this.ca3.Text = "Ca 3";
            this.ca3.UseVisualStyleBackColor = true;
            // 
            // ca4
            // 
            this.ca4.AutoSize = true;
            this.ca4.Location = new System.Drawing.Point(201, 63);
            this.ca4.Margin = new System.Windows.Forms.Padding(4);
            this.ca4.Name = "ca4";
            this.ca4.Size = new System.Drawing.Size(58, 21);
            this.ca4.TabIndex = 17;
            this.ca4.Text = "Ca 4";
            this.ca4.UseVisualStyleBackColor = true;
            // 
            // loaiThi
            // 
            this.loaiThi.Controls.Add(this.CK);
            this.loaiThi.Controls.Add(this.GK);
            this.loaiThi.Location = new System.Drawing.Point(424, 22);
            this.loaiThi.Margin = new System.Windows.Forms.Padding(4);
            this.loaiThi.Name = "loaiThi";
            this.loaiThi.Padding = new System.Windows.Forms.Padding(4);
            this.loaiThi.Size = new System.Drawing.Size(295, 59);
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
            this.caThi.Location = new System.Drawing.Point(424, 89);
            this.caThi.Margin = new System.Windows.Forms.Padding(4);
            this.caThi.Name = "caThi";
            this.caThi.Padding = new System.Windows.Forms.Padding(4);
            this.caThi.Size = new System.Drawing.Size(295, 102);
            this.caThi.TabIndex = 19;
            this.caThi.TabStop = false;
            this.caThi.Text = "Chọn ca thi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Xem lịch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // makeExamSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 253);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "makeExamSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button button1;
    }
}