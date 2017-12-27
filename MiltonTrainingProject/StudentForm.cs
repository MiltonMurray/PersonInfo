using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using PServices;

namespace MiltonTrainingProject
{
    public partial class StudentForm : Form
    {
        public bool IsEdit { get; set; }
        public MainForm MainForm { get; set; }
        public Student Student { get; set; }
        
        public StudentForm(MainForm m, Student s = null)
        {
            InitializeComponent();
            MainForm = m;
            Student = s;
        }
        private bool Collect()
        {
            if (!IsEdit)
            {
                Student = new Student();
            }
            try{

                Student.FirstName = txtFirstName.Text;
                Student.LastName = txtLastName.Text;
                Student.DOB = Convert.ToDateTime(dtDOB.Text);
                Student.SSN = int.Parse(txtSSN.Text);
                Student.Gender = cbGender.Text.GetEnumFromString<Gender>();
                Student.MaritalStatus = cbMaritalStatus.Text.GetEnumFromString<MaritalStatus>();
                Student.College =  (College)cbCollege.SelectedItem;
                Student.AvgHours = int.Parse(txtAvrgHours.Text);
                Student.College_year = cbYear.Text.GetEnumFromString<CollegeYear>();
                Student.Date_start = Convert.ToDateTime(dtStarted.Text);
                Student.HasLoans = cbHasLoans.Checked;
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            string[] n = Enum.GetNames(typeof(Gender));
            int[] v = (int[])Enum.GetValues(typeof(Gender));
            cbGender.AddItemsToBox(n,v);

            n = Enum.GetNames(typeof(MaritalStatus));
            v = (int[])Enum.GetValues(typeof(MaritalStatus));
            cbMaritalStatus.AddItemsToBox(n, v);

            n = Enum.GetNames(typeof(CollegeYear));
            v = (int[])Enum.GetValues(typeof(CollegeYear));
            cbYear.AddItemsToBox(n, v);

            cbCollege.AddCollegesToBox(new CollegeService().SelectAll());

            if (Student != null)
            {
                txtLastName.Text = Student.LastName;
                txtFirstName.Text = Student.FirstName;                
                cbGender.Text = Enum.GetName(typeof(Gender), Student.Gender);     
                cbMaritalStatus.Text = Enum.GetName(typeof(MaritalStatus), Student.MaritalStatus);
                dtDOB.Text = Student.DOB.ToShortDateString();
                txtSSN.Text = Student.SSN.ToString();
                cbCollege.Text = Student.College.ToString();
                dtStarted.Text = Student.Date_start.ToShortDateString();
                cbYear.Text = Enum.GetName(typeof(CollegeYear), Student.College_year);
                txtAvrgHours.Text = Student.AvgHours.ToString();
                cbHasLoans.Checked = Student.HasLoans;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            StudentService serv = new StudentService();

            if (Collect())
            {
                if (IsEdit)
                {
                    serv.Update(Student);
                    MessageBox.Show("Record updated successfully.");
                    Close();
                }
                else
                {
                    serv.Add(Student);
                    MessageBox.Show("New record inserted successfully.");
                    Close();
                }
                MainForm.refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
