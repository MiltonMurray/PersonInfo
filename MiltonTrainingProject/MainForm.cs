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
using MiltonTrainingProject.Data;

namespace MiltonTrainingProject
{
    public partial class MainForm : Form
    {
        int mouseover;
        DataGridView currentGV;
        DataBaseConnection connect;
        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            connect = new DataBaseConnection();
            ds = connect.GetConnection;
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
