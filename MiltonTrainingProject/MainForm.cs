using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PServices;
using Models;


namespace MiltonTrainingProject
{
    public partial class MainForm : Form
    {
        Form1 form1;
        DataGridView currentGrid;  
        public DataGridView getGrid { get { return currentGrid; } }

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {          
            EmployeeGrid.AddEmployeeToGrid(new EmployeeService().SelectAll());
           // EmployeeGrid.AddPersonToGrid(new Services().SelectAll());
            //StudentGrid.AddStudentToGrid(new StudentService().SelectAll());
            CollegeGridView1.AddCollegeToGrid(new CollegeService().SelectAll());
            currentGrid = EmployeeGrid;
           

            gridDeleteLink();
            gridEditLink();
        }
        public void refresh()
        {            
            currentGrid.Rows.Clear();
            if (currentGrid == EmployeeGrid)
            {
                currentGrid.AddEmployeeToGrid(new EmployeeService().SelectAll());
            }
            else
            {
                currentGrid.AddPersonToGrid(new Services().SelectAll());
            }
            
        }

        private void gridEditLink()
        {
            var editLink = new DataGridViewLinkColumn();
            editLink.Name = "dataEdit";
            editLink.HeaderText = "Edit";
            editLink.Text = "Edit";
            editLink.UseColumnTextForLinkValue = true;
            this.currentGrid.Columns.Add(editLink);
        }

        private void gridDeleteLink()
        {
            var deleteLink = new DataGridViewLinkColumn();
            deleteLink.Name = "dataDelete";
            deleteLink.HeaderText = "Delete";
            deleteLink.Text = "Delete";
            deleteLink.UseColumnTextForLinkValue = true;
            this.currentGrid.Columns.Add(deleteLink);
        }
        
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 = new Form1(this);
            form1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Services data = new Services();
            int id =Int32.Parse(EmployeeGrid.Rows[e.RowIndex].Tag.ToString());
            string curr = EmployeeGrid.CurrentCell.Value.ToString();
            
            if (curr == "Delete")
            {
                try
                {
                    EmployeeGrid.Rows.RemoveAt(e.RowIndex);
                    data.Delete(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Happend");
                }
            }
            if (curr == "Edit")
            {
                if (currentGrid == EmployeeGrid)
                {
                    form1 = new Form1(this,currentGrid.Rows[e.RowIndex].GetPersonFromGrid());
                    form1.isEdit = true;
                    form1.ShowDialog();                                 
                }
                                                      
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CollegeForm cform = new CollegeForm(this);
            cform.Show();

        }
        private void HideGrids()
        {
            EmployeeGrid.Hide();
            CollegeGridView1.Hide();
        }
        private void mnuCollegeFilter_Click(object sender, EventArgs e)
        {
            HideGrids();
            CollegeGridView1.Show();
            currentGrid = CollegeGridView1;
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HideGrids();
            EmployeeGrid.Show();
            currentGrid = EmployeeGrid;
        }

        private void collegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm sForm = new StudentForm(this);
            sForm.Show();

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm eForm = new EmployeeForm(this);
            eForm.Show();
        }
    }
}
