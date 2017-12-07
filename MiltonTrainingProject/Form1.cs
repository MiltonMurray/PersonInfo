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
        private MainForm mform;

        public Form1(MainForm form, Person p = null)
        {
            InitializeComponent();
            Person = p;
            mform = form;
        }

        /// <summary>
        /// Either adds or updates record based on edit click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {                          
            Services serv = new Services();
          
            if (collect())
            {
                if (isEdit)
                {                                
                    serv.Update(Person);
                    MessageBox.Show("Record updated successfully.");
                    Close();
                }
                else
                {
                    serv.Add(Person);             
                    MessageBox.Show("New record inserted successfully.");
                    Close();
                }
                mform.refresh();
            }                           
        }

        /// <summary>
        /// True: if nothing is being edited, then populates model class
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //gets the name and value of enums and store them in the combobox
            string[] n = Enum.GetNames(typeof(Gender));         
            int[] v = (int[])Enum.GetValues(typeof(Gender));     
            cbGender.AddItemsToBox(n, v);

            n = Enum.GetNames(typeof(MaritalStatus));
            v = (int[])Enum.GetValues(typeof(MaritalStatus));
            cbMaritalStatus.AddItemsToBox(n, v);

            //set text fields to Model values
            if (Person != null)
            {
                txtLastName.Text = Person.LastName;
                txtFirstName.Text = Person.FirstName;              
                // departmentBox.Text = Enum.GetName(typeof(Department), Employee.Department);
                cbGender.Text = Enum.GetName(typeof(Gender), Person.Gender);
                //gymMemberBox.Text = Enum.GetName(typeof(Membership), Employee.GymMember);
                cbMaritalStatus.Text = Enum.GetName(typeof(MaritalStatus), Person.MaritalStatus);
                //collegeBox.SelectedIndex = collegeBox.FindCollegeIndex(Employee.College);
                dPicker.Text = Person.DOB.ToShortDateString();
                //hiredPicker.Text = Employee.HireDate.ToShortDateString();
                txtSSN.Text = Person.SSN.ToString();
               
            }
        }
        /// <summary>
        /// "CANCEL" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}