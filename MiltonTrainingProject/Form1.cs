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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int intResult = 0;

            // Page is valid, lets go ahead and insert records
            // Instantiate BAL object
            Services data = new Services();

            // Instantiate the object we have to deal with            
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            DateTime dob = Convert.ToDateTime(dPicker.Text);
            int ssn = Int32.Parse(txtSSN.Text);
            string gender = cbGender.Text;
            string mstat = cbMaritalStatus.Text;

            try
            {
                intResult = data.Insert(fname, lname, dob, ssn, gender, mstat);
                if (intResult > 0)
                    MessageBox.Show("New record inserted successfully.");
                else
                    MessageBox.Show("FirstName [<b>" + txtFirstName.Text + "</b>] alredy exists, try another name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                data = null;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}