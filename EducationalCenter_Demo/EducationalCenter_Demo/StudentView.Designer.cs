
namespace EducationalCenter_Demo
{
    partial class StudentView
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
            this.EnrollClass_button = new System.Windows.Forms.Button();
            this.SeeResult_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnrollClass_button
            // 
            this.EnrollClass_button.Location = new System.Drawing.Point(60, 107);
            this.EnrollClass_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnrollClass_button.Name = "EnrollClass_button";
            this.EnrollClass_button.Size = new System.Drawing.Size(252, 95);
            this.EnrollClass_button.TabIndex = 0;
            this.EnrollClass_button.Text = "Đăng ký học phần";
            this.EnrollClass_button.UseVisualStyleBackColor = true;
            this.EnrollClass_button.Click += new System.EventHandler(this.EnrollClass_button_Click);
            // 
            // SeeResult_button
            // 
            this.SeeResult_button.Location = new System.Drawing.Point(389, 107);
            this.SeeResult_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeResult_button.Name = "SeeResult_button";
            this.SeeResult_button.Size = new System.Drawing.Size(267, 95);
            this.SeeResult_button.TabIndex = 1;
            this.SeeResult_button.Text = "Xem kết quả đăng ký học phần";
            this.SeeResult_button.UseVisualStyleBackColor = true;
            this.SeeResult_button.Click += new System.EventHandler(this.SeeResult_button_Click);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.SeeResult_button);
            this.Controls.Add(this.EnrollClass_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chào mừng học viên";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnrollClass_button;
        private System.Windows.Forms.Button SeeResult_button;
    }
}