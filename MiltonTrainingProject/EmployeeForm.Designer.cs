namespace MiltonTrainingProject
{
    partial class EmployeeForm
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
            this.e_cbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // e_cbGender
            // 
            this.e_cbGender.FormattingEnabled = true;
            this.e_cbGender.Location = new System.Drawing.Point(117, 107);
            this.e_cbGender.Name = "e_cbGender";
            this.e_cbGender.Size = new System.Drawing.Size(121, 21);
            this.e_cbGender.TabIndex = 0;
            this.e_cbGender.Text = "Gender";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 267);
            this.Controls.Add(this.e_cbGender);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox e_cbGender;
    }
}