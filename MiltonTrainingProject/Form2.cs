using MiltonTrainingProject.Data;
using MiltonTrainingProject.Model;
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
    public partial class Form2 : Form
    {
        DataBaseConnection objConnect;
        string conString;

        DataSet ds;

        int MaxRows;
        int inc = 0;

        Form1 pForm = new Form1();

        public Form2()
        {
            InitializeComponent();
            connectData();
        }

        public DataGridView mainGrid
        {
            get { return dataGridView1; }
        }

        private void connectData()
        {
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNTERN_TESTDataSet.MM_Person' table. You can move, or remove it, as needed.
            this.mM_PersonTableAdapter.Fill(this.iNTERN_TESTDataSet.MM_Person);

            

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            pForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
