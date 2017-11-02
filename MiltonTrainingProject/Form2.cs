using MiltonTrainingProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiltonTrainingProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
             try
            {
                objConnect = new DataBaseConnection();
                conString = Properties.Settings.Default.PersonConnectionString;

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
        
        DataBaseConnection objConnect;
        string conString;

        DataSet ds;

        int MaxRows;
        int inc = 0;

        
       
        public DataGridView mainGrid
        {
            get { return dataGridView1; }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNTERN_TESTDataSet.MM_Person' table. You can move, or remove it, as needed.
            this.mM_PersonTableAdapter.Fill(this.iNTERN_TESTDataSet.MM_Person);
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
