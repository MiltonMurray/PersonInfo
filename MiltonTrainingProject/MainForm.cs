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
        public DataGridView getGrid { get { return currentGrid; } }
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
            currentGrid = GridView1;

            gridDeleteLink();
            gridEditLink();           

        }
        public void refresh()
        {
            GridView1.Rows.Clear();
            GridView1.AddPersonToGrid(new Services().SelectAll());
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
            form1 = new Form1(this);
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
                if (currentGrid == GridView1)
                {
                    form1 = new Form1(this,currentGrid.Rows[e.RowIndex].GetPersonFromGrid());
                    form1.isEdit = true;
                    form1.ShowDialog();                                 
                }
                                                      
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
