namespace MiltonTrainingProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollegeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollegeFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.collegeHelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mstat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GymMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CollegeGrid = new System.Windows.Forms.DataGridView();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.stFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stSSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stMaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDateStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stCollegeYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stAvgHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stHasLoans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllGrid = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollegeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCollegeAdd,
            this.studentToolStripMenuItem,
            this.collegeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "Add";
            // 
            // mnuCollegeAdd
            // 
            this.mnuCollegeAdd.Name = "mnuCollegeAdd";
            this.mnuCollegeAdd.Size = new System.Drawing.Size(142, 22);
            this.mnuCollegeAdd.Text = "College";
            this.mnuCollegeAdd.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.studentToolStripMenuItem.Text = "Employee";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // collegeToolStripMenuItem
            // 
            this.collegeToolStripMenuItem.Name = "collegeToolStripMenuItem";
            this.collegeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.collegeToolStripMenuItem.Text = "College Help";
            this.collegeToolStripMenuItem.Click += new System.EventHandler(this.collegeToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem1,
            this.mnuCollegeFilter,
            this.employeeToolStripMenuItem2,
            this.collegeHelpToolStripMenuItem1});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.employeeToolStripMenuItem1.Text = "All";
            this.employeeToolStripMenuItem1.Click += new System.EventHandler(this.employeeToolStripMenuItem1_Click);
            // 
            // mnuCollegeFilter
            // 
            this.mnuCollegeFilter.Name = "mnuCollegeFilter";
            this.mnuCollegeFilter.Size = new System.Drawing.Size(142, 22);
            this.mnuCollegeFilter.Text = "College";
            this.mnuCollegeFilter.Click += new System.EventHandler(this.mnuCollegeFilter_Click);
            // 
            // employeeToolStripMenuItem2
            // 
            this.employeeToolStripMenuItem2.Name = "employeeToolStripMenuItem2";
            this.employeeToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.employeeToolStripMenuItem2.Text = "Employee";
            this.employeeToolStripMenuItem2.Click += new System.EventHandler(this.employeeToolStripMenuItem2_Click);
            // 
            // collegeHelpToolStripMenuItem1
            // 
            this.collegeHelpToolStripMenuItem1.Name = "collegeHelpToolStripMenuItem1";
            this.collegeHelpToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.collegeHelpToolStripMenuItem1.Text = "College Help";
            this.collegeHelpToolStripMenuItem1.Click += new System.EventHandler(this.collegeHelpToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AllowUserToAddRows = false;
            this.EmployeeGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.EmployeeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeeGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lname,
            this.fname,
            this.ssn,
            this.dob,
            this.gender,
            this.mstat,
            this.DateHired,
            this.Department,
            this.GymMember});
            this.EmployeeGrid.GridColor = System.Drawing.SystemColors.Control;
            this.EmployeeGrid.Location = new System.Drawing.Point(0, 27);
            this.EmployeeGrid.MultiSelect = false;
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.EmployeeGrid.ShowEditingIcon = false;
            this.EmployeeGrid.Size = new System.Drawing.Size(1138, 408);
            this.EmployeeGrid.TabIndex = 0;
            this.EmployeeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lname
            // 
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // ssn
            // 
            this.ssn.HeaderText = "Social Security #";
            this.ssn.Name = "ssn";
            this.ssn.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.HeaderText = "Date of Birth";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // mstat
            // 
            this.mstat.HeaderText = "Marital Status";
            this.mstat.Name = "mstat";
            this.mstat.ReadOnly = true;
            // 
            // DateHired
            // 
            this.DateHired.HeaderText = "Date Hired";
            this.DateHired.Name = "DateHired";
            this.DateHired.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // GymMember
            // 
            this.GymMember.HeaderText = "GymMembership";
            this.GymMember.Name = "GymMember";
            this.GymMember.ReadOnly = true;
            // 
            // CollegeGrid
            // 
            this.CollegeGrid.AllowUserToAddRows = false;
            this.CollegeGrid.AllowUserToDeleteRows = false;
            this.CollegeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CollegeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_name,
            this.street,
            this.city,
            this.state,
            this.zip});
            this.CollegeGrid.Location = new System.Drawing.Point(-18, 27);
            this.CollegeGrid.Name = "CollegeGrid";
            this.CollegeGrid.ReadOnly = true;
            this.CollegeGrid.Size = new System.Drawing.Size(1156, 408);
            this.CollegeGrid.TabIndex = 2;
            this.CollegeGrid.Visible = false;
            // 
            // c_name
            // 
            this.c_name.HeaderText = "CollegeName";
            this.c_name.Name = "c_name";
            this.c_name.ReadOnly = true;
            // 
            // street
            // 
            this.street.HeaderText = "Street";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // zip
            // 
            this.zip.HeaderText = "Zip";
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            // 
            // StudentGrid
            // 
            this.StudentGrid.AllowUserToAddRows = false;
            this.StudentGrid.AllowUserToDeleteRows = false;
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stFirstName,
            this.stLastName,
            this.stSSN,
            this.stDOB,
            this.stGender,
            this.stMaritalStatus,
            this.stCollege,
            this.stDateStarted,
            this.stCollegeYear,
            this.stAvgHours,
            this.stHasLoans});
            this.StudentGrid.Location = new System.Drawing.Point(0, 27);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.ReadOnly = true;
            this.StudentGrid.Size = new System.Drawing.Size(1138, 408);
            this.StudentGrid.TabIndex = 3;
            this.StudentGrid.Visible = false;
            this.StudentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGrid_CellContentClick);
            // 
            // stFirstName
            // 
            this.stFirstName.HeaderText = "First Name";
            this.stFirstName.Name = "stFirstName";
            this.stFirstName.ReadOnly = true;
            // 
            // stLastName
            // 
            this.stLastName.HeaderText = "Last Name";
            this.stLastName.Name = "stLastName";
            this.stLastName.ReadOnly = true;
            // 
            // stSSN
            // 
            this.stSSN.HeaderText = "Social Security #";
            this.stSSN.Name = "stSSN";
            this.stSSN.ReadOnly = true;
            // 
            // stDOB
            // 
            this.stDOB.HeaderText = "Date of Birth";
            this.stDOB.Name = "stDOB";
            this.stDOB.ReadOnly = true;
            // 
            // stGender
            // 
            this.stGender.HeaderText = "Gender";
            this.stGender.Name = "stGender";
            this.stGender.ReadOnly = true;
            // 
            // stMaritalStatus
            // 
            this.stMaritalStatus.HeaderText = "Marital Status";
            this.stMaritalStatus.Name = "stMaritalStatus";
            this.stMaritalStatus.ReadOnly = true;
            // 
            // stCollege
            // 
            this.stCollege.HeaderText = "College";
            this.stCollege.Name = "stCollege";
            this.stCollege.ReadOnly = true;
            // 
            // stDateStarted
            // 
            this.stDateStarted.HeaderText = "Start Date";
            this.stDateStarted.Name = "stDateStarted";
            this.stDateStarted.ReadOnly = true;
            // 
            // stCollegeYear
            // 
            this.stCollegeYear.HeaderText = "College Year";
            this.stCollegeYear.Name = "stCollegeYear";
            this.stCollegeYear.ReadOnly = true;
            // 
            // stAvgHours
            // 
            this.stAvgHours.HeaderText = "Average Hours";
            this.stAvgHours.Name = "stAvgHours";
            this.stAvgHours.ReadOnly = true;
            // 
            // stHasLoans
            // 
            this.stHasLoans.HeaderText = "Has Loans";
            this.stHasLoans.Name = "stHasLoans";
            this.stHasLoans.ReadOnly = true;
            // 
            // AllGrid
            // 
            this.AllGrid.AllowUserToAddRows = false;
            this.AllGrid.AllowUserToDeleteRows = false;
            this.AllGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.aSSN,
            this.aDOB,
            this.aGender,
            this.aMaritalStatus});
            this.AllGrid.Location = new System.Drawing.Point(0, 27);
            this.AllGrid.Name = "AllGrid";
            this.AllGrid.ReadOnly = true;
            this.AllGrid.Size = new System.Drawing.Size(1138, 408);
            this.AllGrid.TabIndex = 4;
            this.AllGrid.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // aSSN
            // 
            this.aSSN.HeaderText = "Social Security #";
            this.aSSN.Name = "aSSN";
            this.aSSN.ReadOnly = true;
            // 
            // aDOB
            // 
            this.aDOB.HeaderText = "Date of Birth";
            this.aDOB.Name = "aDOB";
            this.aDOB.ReadOnly = true;
            // 
            // aGender
            // 
            this.aGender.HeaderText = "Gender";
            this.aGender.Name = "aGender";
            this.aGender.ReadOnly = true;
            // 
            // aMaritalStatus
            // 
            this.aMaritalStatus.HeaderText = "Marital Status";
            this.aMaritalStatus.Name = "aMaritalStatus";
            this.aMaritalStatus.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 434);
            this.Controls.Add(this.AllGrid);
            this.Controls.Add(this.StudentGrid);
            this.Controls.Add(this.CollegeGrid);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollegeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
     
        private System.Windows.Forms.BindingSource mMPersonBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mstatDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCollegeAdd;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCollegeFilter;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem collegeHelpToolStripMenuItem1;
        private System.Windows.Forms.DataGridView CollegeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn mstat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn GymMember;
        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stSSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn stGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn stMaritalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn stCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDateStarted;
        private System.Windows.Forms.DataGridViewTextBoxColumn stCollegeYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn stAvgHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn stHasLoans;
        private System.Windows.Forms.DataGridView AllGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMaritalStatus;
    }
}