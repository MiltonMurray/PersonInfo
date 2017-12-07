using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PServices;
using Models;

namespace MiltonTrainingProject
{
    public partial class CollegeForm : Form
    {
        public College college { get; set; }
        public bool isEdit {get; set; }
        private MainForm mform;

        public CollegeForm(MainForm form)
        {
            InitializeComponent();
            mform = form;
        }

        private void CollegeForm_Load(object sender, EventArgs e)
        {
            string[] n = Enum.GetNames(typeof(State));
            int[] v = (int[])Enum.GetValues(typeof(State));
            cbState.AddItemsToBox(n,v);

            if (College)
            {

            }
        }

        private void addCollegebtn_Click(object sender, EventArgs e)
        {
            Services serv = new Services();
            if (collect())
            {
                if (isEdit)
                {
                    serv.Update(College);
                    MessageBox.Show("Record updated successfully.");
                    Close();
                }
                else
                {
                    serv.Add(College);
                    MessageBox.Show("New record inserted successfully.");
                    Close();
                }
                mform.refresh();
            }
        }
        public bool collect()
        {
            if (!isEdit)
            {
                College c = new College();
            }
            try
            {
                college.Name = txtCName.Text;
                college.Street = txtStreet.Text;
                college.State = cbState.Text.GetEnumFromString<State>();
                college.Zip = int.Parse(txtZip.Text);
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;               
            }
        }
    }
}
