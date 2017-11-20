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
            GridView1.Columns["Id"].Visible = false;

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
            //if click is on new row or header row
            if (e.RowIndex == GridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == GridView1.Columns["dataDelete"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                GridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Services data = new Services();

            if (GridView1.Rows.Count > 1 && GridView1.SelectedRows[0].Index != GridView1.Rows.Count - 1)
            {
                int id = Int32.Parse(GridView1.SelectedRows[0].Cells[0].Value.ToString() + "");
                data.Delete(id);
                GridView1.Rows.RemoveAt(GridView1.SelectedRows[0].Index);
                MessageBox.Show("Row Deleted");
            }
            
        }
    }
}
