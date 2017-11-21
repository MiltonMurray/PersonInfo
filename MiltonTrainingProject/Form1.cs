using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Person;


namespace MiltonTrainingProject
{
    public partial class Form1 : Form
    {
        public bool istrue { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
           

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {          

            // Page is valid, lets go ahead and insert records          
            Services data = new Services();

            // Instantiate the object we have to deal with            
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            DateTime dob = Convert.ToDateTime(dPicker.Text);
            int ssn = Int32.Parse(txtSSN.Text);
            string gender = cbGender.Text;
            string mstat = cbMaritalStatus.Text;
         
            data.Insert(fname, lname, dob, ssn, gender, mstat);                     
            MessageBox.Show("New record inserted successfully.");
                    
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}