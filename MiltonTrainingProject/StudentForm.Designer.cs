namespace MiltonTrainingProject
{
    partial class StudentForm
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbCollege = new System.Windows.Forms.ComboBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.dtStarted = new System.Windows.Forms.DateTimePicker();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.txtAvrgHours = new System.Windows.Forms.TextBox();
            this.cbHasLoans = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(31, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(210, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Last Name";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(210, 133);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 3;
            this.cbGender.Text = "Gender";
            // 
            // cbCollege
            // 
            this.cbCollege.FormattingEnabled = true;
            this.cbCollege.Location = new System.Drawing.Point(31, 133);
            this.cbCollege.Name = "cbCollege";
            this.cbCollege.Size = new System.Drawing.Size(121, 21);
            this.cbCollege.TabIndex = 4;
            this.cbCollege.Text = "College";
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(210, 213);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(121, 20);
            this.dtDOB.TabIndex = 5;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(31, 83);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 6;
            this.txtSSN.Text = "SSN";
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.Location = new System.Drawing.Point(31, 171);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(121, 21);
            this.cbMaritalStatus.TabIndex = 7;
            this.cbMaritalStatus.Text = "Marital Status";
            // 
            // dtStarted
            // 
            this.dtStarted.CustomFormat = "MM/dd/yy";
            this.dtStarted.Location = new System.Drawing.Point(31, 215);
            this.dtStarted.Name = "dtStarted";
            this.dtStarted.Size = new System.Drawing.Size(121, 20);
            this.dtStarted.TabIndex = 8;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(210, 171);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 9;
            this.cbYear.Text = "College Year";
            // 
            // txtAvrgHours
            // 
            this.txtAvrgHours.Location = new System.Drawing.Point(210, 83);
            this.txtAvrgHours.Name = "txtAvrgHours";
            this.txtAvrgHours.Size = new System.Drawing.Size(100, 20);
            this.txtAvrgHours.TabIndex = 10;
            this.txtAvrgHours.Text = "Average Hours";
            // 
            // cbHasLoans
            // 
            this.cbHasLoans.AutoSize = true;
            this.cbHasLoans.Location = new System.Drawing.Point(141, 264);
            this.cbHasLoans.Name = "cbHasLoans";
            this.cbHasLoans.Size = new System.Drawing.Size(83, 17);
            this.cbHasLoans.TabIndex = 11;
            this.cbHasLoans.Text = "Has Loans?";
            this.cbHasLoans.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(56, 304);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "ACCEPT";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 356);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cbHasLoans);
            this.Controls.Add(this.txtAvrgHours);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.dtStarted);
            this.Controls.Add(this.cbMaritalStatus);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.cbCollege);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbCollege;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.ComboBox cbMaritalStatus;
        private System.Windows.Forms.DateTimePicker dtStarted;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.TextBox txtAvrgHours;
        private System.Windows.Forms.CheckBox cbHasLoans;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}