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


namespace MiltonTrainingProject
{
    public partial class Form1 : Form
    {
        public bool isEdit { get; set; }
        public int id { get; set; }
        public string Fname
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }
        public string Lname
        {
            get { return txtFirstName.Text; }
            set { txtLastName.Text = value; }
        }
        public string DOB
        {
            get { return dPicker.Text; }
            set { dPicker.Text = value; }
        }
        public string SSN
        {
            get { return txtSSN.Text; }
            set { txtSSN.Text = value; }
        }
        public string Gender
        {
            get { return cbGender.Text; }
            set { cbGender.Text = value; }
        }
        public string MaritalStatus
        {
            get { return cbMaritalStatus.Text; }
            set { cbMaritalStatus.Text = value; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {           

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            MainForm a = new MainForm();
            

            // Page is valid, lets go ahead and insert records          
            Services serv = new Services();

            // Instantiate the object we have to deal with
           
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            DateTime dob = Convert.ToDateTime(dPicker.Text);
            int ssn = int.Parse(txtSSN.Text);
            string gender = cbGender.Text;
            string mstat = cbMaritalStatus.Text;

            if (isEdit)
            {
                serv.Update(id, fname, lname, dob, ssn, gender, mstat);
                MessageBox.Show("Record updated successfully.");
            }
            else
            {
                serv.Insert(fname, lname, dob, ssn, gender, mstat);                     
                MessageBox.Show("New record inserted successfully.");
            }
            
                             
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}