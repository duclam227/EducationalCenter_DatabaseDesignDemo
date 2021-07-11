
namespace EducationalCenter_Demo
{
    partial class EmployeeMainForm
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
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.EnrolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(270, 71);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(159, 57);
            this.ScheduleButton.TabIndex = 0;
            this.ScheduleButton.Text = "Lên lịch thi";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // EnrolButton
            // 
            this.EnrolButton.Location = new System.Drawing.Point(58, 71);
            this.EnrolButton.Name = "EnrolButton";
            this.EnrolButton.Size = new System.Drawing.Size(159, 57);
            this.EnrolButton.TabIndex = 1;
            this.EnrolButton.Text = "Ghi danh";
            this.EnrolButton.UseVisualStyleBackColor = true;
            this.EnrolButton.Click += new System.EventHandler(this.EnrolButton_Click);
            // 
            // EmployeeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(482, 212);
            this.Controls.Add(this.EnrolButton);
            this.Controls.Add(this.ScheduleButton);
            this.MaximizeBox = false;
            this.Name = "EmployeeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chức năng nhân viên";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button EnrolButton;
    }
}