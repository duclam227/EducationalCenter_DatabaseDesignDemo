
namespace EducationalCenter_Demo
{
    partial class ExamScheduleForm
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
            this.ScheduleDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleDataGridView
            // 
            this.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ScheduleDataGridView.Name = "ScheduleDataGridView";
            this.ScheduleDataGridView.RowHeadersWidth = 51;
            this.ScheduleDataGridView.RowTemplate.Height = 24;
            this.ScheduleDataGridView.Size = new System.Drawing.Size(858, 479);
            this.ScheduleDataGridView.TabIndex = 0;
            this.ScheduleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleDataGridView_CellContentClick);
            // 
            // ExamScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.ScheduleDataGridView);
            this.MaximizeBox = false;
            this.Name = "ExamScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch thi";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleDataGridView;
    }
}