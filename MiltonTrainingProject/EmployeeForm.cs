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
    public partial class EmployeeForm : Form
    {
        public bool IsEdit { get; set; }
        public MainForm MainForm { get; set; }
        public Employee Employee { get; set; }
        public EmployeeForm( MainForm m, Employee e = null)
        {
            InitializeComponent();
            MainForm = m;
            Employee = e;
        }
        private bool Collect()
        {
            if (!IsEdit)
            {
                Employee = new Employee();
            }
            try
            {

                Employee.FirstName = txtFirstName.Text;
                Employee.LastName = txtLastName.Text;
                Employee.DOB = Convert.ToDateTime(dtDOB.Text);
                Employee.SSN = int.Parse(txtSSN.Text);
                Employee.Gender = cbGender.Text.GetEnumFromString<Gender>();
                Employee.MaritalStatus = cbMaritalStatus.Text.GetEnumFromString<MaritalStatus>();
                Employee.Date_hired = Convert.ToDateTime(dtDateHired.Text);
                Employee.Department = cbDepartment.Text.GetEnumFromString<Department>();
                Employee.Member = cbMembership.Text.GetEnumFromString<Member>();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            string[] n = Enum.GetNames(typeof(Gender));
            int[] v = (int[])Enum.GetValues(typeof(Gender));
            cbGender.AddItemsToBox(n,v);

            n = Enum.GetNames(typeof(MaritalStatus));
            v = (int[])Enum.GetValues(typeof(MaritalStatus));
            cbMaritalStatus.AddItemsToBox(n, v);

            n = Enum.GetNames(typeof(Department));
            v = (int[])Enum.GetValues(typeof(Department));
            cbDepartment.AddItemsToBox(n, v);

            n = Enum.GetNames(typeof(Member));
            v = (int[])Enum.GetValues(typeof(Member));
            cbMembership.AddItemsToBox(n, v);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
