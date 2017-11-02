using MiltonTrainingProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiltonTrainingProject
{
    public partial class Form1 : Form
    {
        DataBaseConnection objConnect;
        string conString;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int inc = 0;

        string gender;
        Form2 a = new Form2();

        public Form1()
        {
            InitializeComponent();

            try
            {
                
                objConnect = new DataBaseConnection();
                conString = Properties.Settings.Default.ConnectionString;

                objConnect.connection_string = conString; //pass over the connection string to our DatabaseConnection class
                objConnect.Sql = Properties.Settings.Default.SQL; //passed to our DatabaseConnection class via the Sql property before the equal sign

                ds = objConnect.GetConnection;
                MaxRows = ds.Tables[0].Rows.Count;



            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[1] = txtFirstName.Text;
            row[2] = txtLastName.Text;
            row[3] = DOBPicker.Text;
            row[4] = txtSSN.Text;
            row[5] = gender;
            row[6] = cbMaritalStatus.Text;

            ds.Tables[0].Rows.Add(row);

            try
            {
                objConnect.UpdateDatabase(ds);

                MaxRows = MaxRows + 1;
                inc = MaxRows - 1;

                a.mainGrid.Refresh();

                MessageBox.Show("Database updated");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}