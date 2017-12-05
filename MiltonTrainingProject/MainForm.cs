using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PServices;
using Models;


namespace MiltonTrainingProject
{
    public partial class MainForm : Form
    {
        Form1 form1;
        DataGridView currentGrid;  
        public DataGridView getGrid { get { return GridView1; } }
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (true)
            {
            
            }
            GridView1.AddPersonToGrid(new Services().SelectAll());
            
            
            //currentGrid = GridView1;

            gridDeleteLink();
            gridEditLink();           

        }
        

        private void gridEditLink()
        {
            var editLink = new DataGridViewLinkColumn();
            editLink.Name = "dataEdit";
            editLink.HeaderText = "Edit";
            editLink.Text = "Edit";
            editLink.UseColumnTextForLinkValue = true;
            this.GridView1.Columns.Add(editLink);
        }

        private void gridDeleteLink()
        {
            var deleteLink = new DataGridViewLinkColumn();
            deleteLink.Name = "dataDelete";
            deleteLink.HeaderText = "Delete";
            deleteLink.Text = "Delete";
            deleteLink.UseColumnTextForLinkValue = true;
            this.GridView1.Columns.Add(deleteLink);
        }
        
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
       
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Services data = new Services();
            int id =Int32.Parse(GridView1.Rows[e.RowIndex].Tag.ToString());
            string curr = GridView1.CurrentCell.Value.ToString();
            
            if (curr == "Delete")
            {
                try
                {
                    GridView1.Rows.RemoveAt(e.RowIndex);
                    data.Delete(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Happend");
                }
            }
            if (curr == "Edit")
            {
                form1 = new Form1();
                form1.isEdit = true;
                
                DataGridViewRow row = currentGrid.Rows[e.RowIndex];
                form1.id = id;
                form1.TFname = row.Cells[1].Value.ToString();
                form1.TLname = row.Cells[2].Value.ToString();
                form1.TDOB = row.Cells[3].Value.ToString();
                form1.TSSN = row.Cells[4].Value.ToString();
                form1.TGender = row.Cells[5].Value.ToString();
                form1.TMaritalStatus = row.Cells[6].Value.ToString();
                form1.Show();                                            
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
