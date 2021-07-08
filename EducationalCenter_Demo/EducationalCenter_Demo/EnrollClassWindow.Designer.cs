
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
            ((System.ComponentModel.ISupportInitialize)(this.EnrollClass_DataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // EnrollClass_DataGridview
            // 
            this.EnrollClass_DataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollClass_DataGridview.Location = new System.Drawing.Point(95, 274);
            this.EnrollClass_DataGridview.Name = "EnrollClass_DataGridview";
            this.EnrollClass_DataGridview.RowHeadersWidth = 62;
            this.EnrollClass_DataGridview.RowTemplate.Height = 28;
            this.EnrollClass_DataGridview.Size = new System.Drawing.Size(520, 125);
            this.EnrollClass_DataGridview.TabIndex = 0;
            // 
            // EnrollClassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnrollClass_DataGridview);
            this.Name = "EnrollClassWindow";
            this.Text = "dd";
            ((System.ComponentModel.ISupportInitialize)(this.EnrollClass_DataGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EnrollClass_DataGridview;
    }
}