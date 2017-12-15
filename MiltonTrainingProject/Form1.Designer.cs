namespace MiltonTrainingProject
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dPicker = new System.Windows.Forms.DateTimePicker();
            this.collegeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(49, 45);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 12;
            this.txtFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(248, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.Text = "Last Name";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(49, 81);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 11;
            this.txtSSN.Text = "SSN";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(74, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.Location = new System.Drawing.Point(248, 114);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(100, 21);
            this.cbMaritalStatus.TabIndex = 8;
            this.cbMaritalStatus.Text = "Marital Status";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(49, 134);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(100, 21);
            this.cbGender.TabIndex = 16;
            this.cbGender.Text = "Gender";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dPicker
            // 
            this.dPicker.CustomFormat = "MM/dd/yy";
            this.dPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPicker.Location = new System.Drawing.Point(248, 78);
            this.dPicker.Name = "dPicker";
            this.dPicker.Size = new System.Drawing.Size(100, 20);
            this.dPicker.TabIndex = 17;
            // 
            // collegeBox
            // 
            this.collegeBox.FormattingEnabled = true;
            this.collegeBox.Location = new System.Drawing.Point(248, 152);
            this.collegeBox.Name = "collegeBox";
            this.collegeBox.Size = new System.Drawing.Size(121, 21);
            this.collegeBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 248);
            this.Controls.Add(this.collegeBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dPicker);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbMaritalStatus);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtLastName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbMaritalStatus;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dPicker;
        private System.Windows.Forms.ComboBox collegeBox;
    }
}