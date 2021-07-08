
namespace EducationalCenter_Demo
{
    partial class EnrollClassWindow
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
            this.EnrollClass_DataGridview = new System.Windows.Forms.DataGridView();
            this.EnrollClass_Submit = new System.Windows.Forms.Button();
            this.grv_ClassEnrollResult = new System.Windows.Forms.DataGridView();
            this.lb_ClassEnrollResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollClass_DataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_ClassEnrollResult)).BeginInit();
            this.SuspendLayout();
            // 
            // EnrollClass_DataGridview
            // 
            this.EnrollClass_DataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollClass_DataGridview.Location = new System.Drawing.Point(12, 28);
            this.EnrollClass_DataGridview.Name = "EnrollClass_DataGridview";
            this.EnrollClass_DataGridview.RowHeadersWidth = 62;
            this.EnrollClass_DataGridview.RowTemplate.Height = 28;
            this.EnrollClass_DataGridview.Size = new System.Drawing.Size(1439, 233);
            this.EnrollClass_DataGridview.TabIndex = 0;
            // 
            // EnrollClass_Submit
            // 
            this.EnrollClass_Submit.Location = new System.Drawing.Point(670, 277);
            this.EnrollClass_Submit.Name = "EnrollClass_Submit";
            this.EnrollClass_Submit.Size = new System.Drawing.Size(181, 48);
            this.EnrollClass_Submit.TabIndex = 1;
            this.EnrollClass_Submit.Text = "Submit";
            this.EnrollClass_Submit.UseVisualStyleBackColor = true;
            this.EnrollClass_Submit.Click += new System.EventHandler(this.EnrollClass_Submit_Click);
            // 
            // grv_ClassEnrollResult
            // 
            this.grv_ClassEnrollResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_ClassEnrollResult.Location = new System.Drawing.Point(199, 395);
            this.grv_ClassEnrollResult.Name = "grv_ClassEnrollResult";
            this.grv_ClassEnrollResult.RowHeadersWidth = 62;
            this.grv_ClassEnrollResult.RowTemplate.Height = 28;
            this.grv_ClassEnrollResult.Size = new System.Drawing.Size(1001, 330);
            this.grv_ClassEnrollResult.TabIndex = 2;
            // 
            // lb_ClassEnrollResult
            // 
            this.lb_ClassEnrollResult.AutoSize = true;
            this.lb_ClassEnrollResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_ClassEnrollResult.Location = new System.Drawing.Point(12, 332);
            this.lb_ClassEnrollResult.Name = "lb_ClassEnrollResult";
            this.lb_ClassEnrollResult.Size = new System.Drawing.Size(492, 37);
            this.lb_ClassEnrollResult.TabIndex = 3;
            this.lb_ClassEnrollResult.Text = "KẾT QUẢ ĐĂNG KÝ HỌC PHẦN";
            // 
            // EnrollClassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 737);
            this.Controls.Add(this.lb_ClassEnrollResult);
            this.Controls.Add(this.grv_ClassEnrollResult);
            this.Controls.Add(this.EnrollClass_Submit);
            this.Controls.Add(this.EnrollClass_DataGridview);
            this.Name = "EnrollClassWindow";
            this.Text = "Đăng ký học phần";
            ((System.ComponentModel.ISupportInitialize)(this.EnrollClass_DataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_ClassEnrollResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EnrollClass_DataGridview;
        private System.Windows.Forms.Button EnrollClass_Submit;
        private System.Windows.Forms.DataGridView grv_ClassEnrollResult;
        private System.Windows.Forms.Label lb_ClassEnrollResult;
    }
}