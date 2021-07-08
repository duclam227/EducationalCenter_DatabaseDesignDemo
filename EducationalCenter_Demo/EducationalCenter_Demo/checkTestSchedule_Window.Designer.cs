
namespace EducationalCenter_Demo
{
    partial class checkTestSchedule_Window
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
            this.checkTestSchedule_Gridview = new System.Windows.Forms.DataGridView();
            this.checkTestSchedule_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkTestSchedule_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // checkTestSchedule_Gridview
            // 
            this.checkTestSchedule_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkTestSchedule_Gridview.Location = new System.Drawing.Point(1, 180);
            this.checkTestSchedule_Gridview.Name = "checkTestSchedule_Gridview";
            this.checkTestSchedule_Gridview.RowHeadersWidth = 62;
            this.checkTestSchedule_Gridview.RowTemplate.Height = 28;
            this.checkTestSchedule_Gridview.Size = new System.Drawing.Size(795, 258);
            this.checkTestSchedule_Gridview.TabIndex = 0;
            // 
            // checkTestSchedule_Button
            // 
            this.checkTestSchedule_Button.Location = new System.Drawing.Point(269, 53);
            this.checkTestSchedule_Button.Name = "checkTestSchedule_Button";
            this.checkTestSchedule_Button.Size = new System.Drawing.Size(252, 70);
            this.checkTestSchedule_Button.TabIndex = 1;
            this.checkTestSchedule_Button.Text = "Xem lịch thi";
            this.checkTestSchedule_Button.UseVisualStyleBackColor = true;
            // 
            // checkTestSchedule_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkTestSchedule_Button);
            this.Controls.Add(this.checkTestSchedule_Gridview);
            this.Name = "checkTestSchedule_Window";
            this.Text = "Xem lịch thi";
            ((System.ComponentModel.ISupportInitialize)(this.checkTestSchedule_Gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView checkTestSchedule_Gridview;
        private System.Windows.Forms.Button checkTestSchedule_Button;
    }
}