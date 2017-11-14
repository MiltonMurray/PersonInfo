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
using MiltonTrainingProject.Model;
using System.Data.SqlClient;

namespace MiltonTrainingProject
{
    public partial class Form1 : Form
    {
        private string cs = "Data Source = sql_dev; Initial Catalog = INTERN_TEST; Integrated Security = True";
        public Person person { get; set; }
        SqlCommand cmd;
        SqlConnection cn;

        public Form1()
        {
            InitializeComponent();

            cn = new SqlConnection(cs);
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
        }

        private void Form1_load(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            DateTime dob = Convert.ToDateTime(dPicker.Text);
            int ssn = Int32.Parse(txtSSN.Text);
            string gender = cbGender.Text;
            string mstat = cbMaritalStatus.Text;

            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO MM_Person values (@fname, @lname, @dob, @ssn, @gender, @mstat)";
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@ssn", ssn);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@mstat", mstat);

            if (cn.State == ConnectionState.Closed) cn.Open();

            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Successfully added");


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}