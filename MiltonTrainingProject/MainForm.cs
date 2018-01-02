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
        DataGridView currentGrid;

        public DataGridView getGrid { get { return currentGrid; } }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AllGrid.AddPersonToGrid(new Services().SelectAll());
            EmployeeGrid.AddEmployeeToGrid(new EmployeeService().SelectAll());           
            StudentGrid.AddStudentToGrid(new StudentService().SelectAll());
            CollegeGrid.AddCollegeToGrid(new CollegeService().SelectAll());
            AddLinks();

        }

        private void AddLinks()
        {
            currentGrid = CollegeGrid;
            gridEditLink();
            gridDeleteLink();
            currentGrid = StudentGrid;
            gridEditLink();
            gridDeleteLink();
            currentGrid = EmployeeGrid;
            gridEditLink();
            gridDeleteLink();
        }

        public void refresh()
        {
            currentGrid.Rows.Clear();

            if (currentGrid == EmployeeGrid)
            {
                currentGrid.AddEmployeeToGrid(new EmployeeService().SelectAll());
            }
            else if (currentGrid == StudentGrid)
            {
                currentGrid.AddStudentToGrid(new StudentService().SelectAll());
            }
            else
            {
                currentGrid.AddCollegeToGrid(new CollegeService().SelectAll());
                StudentGrid.Rows.Clear();
                StudentGrid.AddStudentToGrid(new StudentService().SelectAll());
            }

        }

        private void gridEditLink()
        {
            var editLink = new DataGridViewLinkColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForLinkValue = true
            };

            this.currentGrid.Columns.Add(editLink);
        }
        private void gridDeleteLink()
        {
            var deleteLink = new DataGridViewLinkColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForLinkValue = true
            };

            this.currentGrid.Columns.Add(deleteLink);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Int32.Parse(currentGrid.Rows[e.RowIndex].Tag.ToString());
            string curr = currentGrid.CurrentCell.Value.ToString();

            if (curr == "Delete")
            {
                try
                {
                    Employee emp = new Employee();
                    EmployeeService serv = new EmployeeService();
                    serv.Delete(emp, id);

                    this.refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (curr == "Edit")
            {

                EmployeeForm emp = new EmployeeForm(this, EmployeeGrid.Rows[e.RowIndex].GetEmployeeFromGrid());
                emp.IsEdit = true;
                emp.ShowDialog();

            }

        }
        private void StudentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(currentGrid.Rows[e.RowIndex].Tag.ToString());
            string curr = currentGrid.CurrentCell.Value.ToString();

            if (curr == "Delete")
            {
                try
                {
                    Student stu = new Student();
                    StudentService serv = new StudentService();
                    serv.Delete(stu, id);

                    this.refresh();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (curr == "Edit")
            {

                StudentForm std = new StudentForm(this, StudentGrid.Rows[e.RowIndex].GetStudentFromGrid());
                std.IsEdit = true;
                std.ShowDialog();


            }
        }
        private void CollegeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(currentGrid.Rows[e.RowIndex].Tag.ToString());
            string name = currentGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string curr = currentGrid.CurrentCell.Value.ToString();

            if (curr == "Delete")
            {
                try
                {
                    College c = new College();
                    CollegeService data = new CollegeService();
                    data.Delete(id);

                    this.refresh();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (curr == "Edit")
            {

                CollegeForm cc = new CollegeForm(this, CollegeGrid.Rows[e.RowIndex].GetCollegeFromGrid());
                cc.IsEdit = true;
                cc.ShowDialog();


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
            StudentGrid.Hide();
            EmployeeGrid.Hide();
            CollegeGrid.Hide();
            AllGrid.Hide();
        }
        private void mnuCollegeFilter_Click(object sender, EventArgs e)
        {
            HideGrids();
            CollegeGrid.Show();
            currentGrid = CollegeGrid;
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

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HideGrids();
            currentGrid = EmployeeGrid;
            EmployeeGrid.Show();

        }

        private void collegeHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HideGrids();
            currentGrid = StudentGrid;
            StudentGrid.Show();

        }
        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HideGrids();
            AllGrid.Show();
            currentGrid = AllGrid;
        }

        private void AllGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
