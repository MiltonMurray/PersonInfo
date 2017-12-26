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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cbMembership = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.dtDateHired = new System.Windows.Forms.DateTimePicker();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(65, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First Name";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(65, 89);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 1;
            this.txtSSN.Text = "SSN";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(241, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Last Name";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(241, 89);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 3;
            this.cbGender.Text = "Gender";
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.Location = new System.Drawing.Point(44, 139);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(121, 21);
            this.cbMaritalStatus.TabIndex = 4;
            this.cbMaritalStatus.Text = "Marital Status";
            // 
            // cbMembership
            // 
            this.cbMembership.FormattingEnabled = true;
            this.cbMembership.Location = new System.Drawing.Point(44, 184);
            this.cbMembership.Name = "cbMembership";
            this.cbMembership.Size = new System.Drawing.Size(121, 21);
            this.cbMembership.TabIndex = 5;
            this.cbMembership.Text = "Gym Membership";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(241, 139);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbDepartment.TabIndex = 6;
            this.cbDepartment.Text = "Department";
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "MM/dd/yy";
            this.dtDOB.Location = new System.Drawing.Point(241, 185);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(149, 20);
            this.dtDOB.TabIndex = 7;
            // 
            // dtDateHired
            // 
            this.dtDateHired.CustomFormat = "MM/dd/yyyy";
            this.dtDateHired.Location = new System.Drawing.Point(131, 246);
            this.dtDateHired.Name = "dtDateHired";
            this.dtDateHired.Size = new System.Drawing.Size(154, 20);
            this.dtDateHired.TabIndex = 8;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(90, 290);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "ACCEPT";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 358);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dtDateHired);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.cbMembership);
            this.Controls.Add(this.cbMaritalStatus);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtFirstName);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbMaritalStatus;
        private System.Windows.Forms.ComboBox cbMembership;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.DateTimePicker dtDateHired;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}