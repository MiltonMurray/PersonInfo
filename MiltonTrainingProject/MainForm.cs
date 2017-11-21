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

            gridDeleteButton();

        }

      

        private void gridDeleteButton()
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
            Form1 form1 = new Form1();
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
            DataGridViewRow selectedRow;

            //if click is on new row or header row
            if (e.RowIndex == GridView1.NewRowIndex || e.RowIndex < 0)
                return;

            if (GridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = GridView1.SelectedCells[0].RowIndex;
                selectedRow = GridView1.Rows[selectedrowindex];

                int id =Int32.Parse(selectedRow.Cells["ID"].Value.ToString());
                GridView1.Rows.RemoveAt(e.RowIndex);
                data.Delete(id);
            }
           
                //Put some logic here, for example to remove row from your binding list.
                
               // int id = Int32.Parse(GridView1.SelectedRows[e.RowIndex].Cells["id"].Value.ToString() + "");
               
                
            
        }
    }
}
