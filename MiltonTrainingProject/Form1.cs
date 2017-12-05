using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PServices;
using Models;


namespace MiltonTrainingProject
{
    public partial class Form1 : Form
    {
        public bool isEdit { get; set; }
        public Person Person { get; set; }
        public int id { get; set; }
        public string TFname
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }
        public string TLname
        {
            get { return txtFirstName.Text; }
            set { txtLastName.Text = value; }
        }
        public string TDOB
        {
            get { return dPicker.Text; }
            set { dPicker.Text = value; }
        }
        public string TSSN
        {
            get { return txtSSN.Text; }
            set { txtSSN.Text = value; }
        }
        public string TGender
        {
            get { return cbGender.Text; }
            set { cbGender.Text = value; }
        }
        public string TMaritalStatus
        {
            get { return cbMaritalStatus.Text; }
            set { cbMaritalStatus.Text = value; }
        }


        public Form1()
        {
            InitializeComponent();           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MainForm a = new MainForm();
            

            // Page is valid, lets go ahead and insert records          
            Services serv = new Services();

       
           
            if (collect())
            {
                if (isEdit)
                {
                    serv.Update(Person);
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    serv.Add(Person);             
                    MessageBox.Show("New record inserted successfully.");
                }
            }
           
           
                             
        }
        private bool collect()
        {
            if (!isEdit)
            {
                Person = new Person();
            }
            try
            {
                Person.FirstName = txtFirstName.Text;
                Person.LastName = txtLastName.Text;
                Person.DOB = Convert.ToDateTime(dPicker.Text);
                Person.SSN = int.Parse(txtSSN.Text);
                Person.Gender = cbGender.Text.GetEnumFromString<Gender>();
                Person.MaritalStatus = cbMaritalStatus.Text.GetEnumFromString<MaritalStatus>();

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string[] n = Enum.GetNames(typeof(Gender));
            int[] v = (int[])Enum.GetValues(typeof(Gender));
            cbGender.AddItemsToBox(n, v);

            n = Enum.GetNames(typeof(MaritalStatus));
            v = (int[])Enum.GetValues(typeof(MaritalStatus));
            cbMaritalStatus.AddItemsToBox(n, v);


            if (Person != null)
            {
                txtFirstName.Text = Person.FirstName;
                txtLastName.Text = Person.LastName;
                // departmentBox.Text = Enum.GetName(typeof(Department), Employee.Department);
                cbGender.Text = Enum.GetName(typeof(Gender), Person.Gender);
                //gymMemberBox.Text = Enum.GetName(typeof(Membership), Employee.GymMember);
                cbMaritalStatus.Text = Enum.GetName(typeof(MaritalStatus), Person.MaritalStatus);
                //collegeBox.SelectedIndex = collegeBox.FindCollegeIndex(Employee.College);
                dPicker.Text = Person.DOB.ToShortDateString();
                //hiredPicker.Text = Employee.HireDate.ToShortDateString();
                int ssn = int.Parse(txtSSN.Text);
                ssn = Person.SSN;
            }
        }
    }
}