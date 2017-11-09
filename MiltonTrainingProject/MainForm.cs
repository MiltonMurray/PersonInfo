using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiltonTrainingProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int mouseover;
        DataGridView currentGV;
        private void MainForm_Load(object sender, EventArgs e)
        {
           
            string cs = "Data Source = sql_dev; Initial Catalog = INTERN_TEST; Integrated Security = True";

            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter ad = new SqlDataAdapter("SELECT fname, lname, ssn, dob, gender, mstat FROM MM_PERSON", cn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "MM_Person");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)currentGV.Rows[mouseover].Tag;
                            if (currentGV == dataGridView1)
                            {
                                MessageBox.Show("Mouseover Click Works");
                            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
