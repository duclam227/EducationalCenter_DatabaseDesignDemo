
namespace EducationalCenter_Demo
{
    partial class EnrollResult
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
            this.grv_EnrollResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grv_EnrollResult)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_EnrollResult
            // 
            this.grv_EnrollResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_EnrollResult.Location = new System.Drawing.Point(12, 50);
            this.grv_EnrollResult.Name = "grv_EnrollResult";
            this.grv_EnrollResult.RowHeadersWidth = 62;
            this.grv_EnrollResult.RowTemplate.Height = 28;
            this.grv_EnrollResult.Size = new System.Drawing.Size(1039, 502);
            this.grv_EnrollResult.TabIndex = 0;
            // 
            // EnrollResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 576);
            this.Controls.Add(this.grv_EnrollResult);
            this.Name = "EnrollResult";
            this.Text = "Kết quả đăng ký học phần";
            ((System.ComponentModel.ISupportInitialize)(this.grv_EnrollResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_EnrollResult;
    }
}