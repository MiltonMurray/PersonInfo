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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mstat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CollegeGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollegeGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1040, 24);
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
            this.mnuCollegeAdd.Size = new System.Drawing.Size(152, 22);
            this.mnuCollegeAdd.Text = "College";
            this.mnuCollegeAdd.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studentToolStripMenuItem.Text = "Employee";
            // 
            // collegeToolStripMenuItem
            // 
            this.collegeToolStripMenuItem.Name = "collegeToolStripMenuItem";
            this.collegeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.collegeToolStripMenuItem.Text = "College Help";
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
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.employeeToolStripMenuItem1.Text = "All";
            // 
            // mnuCollegeFilter
            // 
            this.mnuCollegeFilter.Name = "mnuCollegeFilter";
            this.mnuCollegeFilter.Size = new System.Drawing.Size(152, 22);
            this.mnuCollegeFilter.Text = "College";
            this.mnuCollegeFilter.Click += new System.EventHandler(this.mnuCollegeFilter_Click);
            // 
            // employeeToolStripMenuItem2
            // 
            this.employeeToolStripMenuItem2.Name = "employeeToolStripMenuItem2";
            this.employeeToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.employeeToolStripMenuItem2.Text = "Employee";
            // 
            // collegeHelpToolStripMenuItem1
            // 
            this.collegeHelpToolStripMenuItem1.Name = "collegeHelpToolStripMenuItem1";
            this.collegeHelpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.collegeHelpToolStripMenuItem1.Text = "College Help";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToAddRows = false;
            this.GridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lname,
            this.fname,
            this.ssn,
            this.dob,
            this.gender,
            this.mstat});
            this.GridView1.GridColor = System.Drawing.SystemColors.Control;
            this.GridView1.Location = new System.Drawing.Point(12, 38);
            this.GridView1.MultiSelect = false;
            this.GridView1.Name = "GridView1";
            this.GridView1.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView1.ShowEditingIcon = false;
            this.GridView1.Size = new System.Drawing.Size(1016, 384);
            this.GridView1.TabIndex = 0;
            this.GridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // CollegeGridView1
            // 
            this.CollegeGridView1.AllowUserToAddRows = false;
            this.CollegeGridView1.AllowUserToDeleteRows = false;
            this.CollegeGridView1.AllowUserToOrderColumns = true;
            this.CollegeGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CollegeGridView1.Location = new System.Drawing.Point(72, 72);
            this.CollegeGridView1.Name = "CollegeGridView1";
            this.CollegeGridView1.ReadOnly = true;
            this.CollegeGridView1.Size = new System.Drawing.Size(713, 298);
            this.CollegeGridView1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 434);
            this.Controls.Add(this.CollegeGridView1);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollegeGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCollegeAdd;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCollegeFilter;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem collegeHelpToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn mstat;
        private System.Windows.Forms.DataGridView CollegeGridView1;
    }
}