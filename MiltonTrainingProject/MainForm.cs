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
    public partial class MainForm : Form
    {
        Form1 form1;
        DataGridView currentGrid;   
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            Services connect = new Services();
            DataSet ds = connect.GetConnection;
            GridView1.DataSource = ds.Tables[0];
            GridView1.Columns["ID"].Visible = false;
            currentGrid = GridView1;

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
            int id =Int32.Parse(GridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
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
                    MessageBox.Show(ex.Message);
                }
            }
            if (curr == "Edit")
            {
                DataGridViewRow row = currentGrid.Rows[e.RowIndex];
                Form1 pForm = new Form1();
                pForm.ShowDialog();

                //if (form1.istrue)
                //{
                //    currentGrid.Rows[e.RowIndex].PutEmployeeInGrid(eForm.Employee);
                //    allGrid.Rows[allGrid.FindRow(eForm.Employee.ID)].PutPersonInGrid(new Person(eForm.Employee));
                //}

              
                //data.Update(id);
               
            }

        }
        protected void UpdateRecord(object sender, DataGridViewCellEventArgs e)
        {

            
            //DataGridViewRow row = GridView1.Rows[e.RowIndex];

            //TextBox tFN = (TextBox)row.FindControl("txtFName");
            //TextBox tLN = (TextBox)row.FindControl("txtLName");
            //TextBox tAge = (TextBox)row.FindControl("txtAge");

            //// instantiate BAL
            //Services pBAL = new Services();

            //pBAL.Update( tFN.Text, tLN.Text, int.Parse(tAge.Text));
                          

        }
    }
}
