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
       
        public Person person { get; set; } 

        public Form1()
        {
            InitializeComponent();

        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source = sql_dev; Initial Catalog = INTERN_TEST; Integrated Security = True";

            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM MM_PERSON", cn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "MM_Person");
                   MessageBox.Show(dPicker.Text);
            try
            {
                DateTime dt = Convert.ToDateTime(dPicker.Text);
                DataRow row = ds.Tables[0].NewRow();
                row[1] = txtFirstName.Text;
                row[2] = txtLastName.Text;
                
                        row[3] = dt;
                        row[4] = Int32.Parse(txtSSN.Text);
                        row[5] = cbGender.Text;
                        row[6] = cbMaritalStatus.Text;

                        ds.Tables[0].Rows.Add(row);
                        ad.Update(ds.Tables[0]);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}