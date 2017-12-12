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
        public College College { get; set; }
        public bool IsEdit {get; set; }
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

            if (College != null)
            {
                txtCity.Text = College.City;
                txtCName.Text = College.Name;
                cbState.Text = Enum.GetName(typeof(State),College.State);
                txtStreet.Text = College.Street;
                txtZip.Text = College.Zip.ToString();
            }
        }

        private void addCollegebtn_Click(object sender, EventArgs e)
        {
            CollegeService serv = new CollegeService();
            if (collect())
            {
                if (IsEdit)
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
            if (!IsEdit)
            {
                College = new College();
            }
            try
            {
                College.Name = txtCName.Text;
                College.Street = txtStreet.Text;
                College.City = txtCity.Text;
                College.State = cbState.Text.GetEnumFromString<State>();
                College.Zip = int.Parse(txtZip.Text);
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
