﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'iNTERN_TESTDataSet.MM_Person' table. You can move, or remove it, as needed.
            this.mM_PersonTableAdapter.Fill(this.iNTERN_TESTDataSet.MM_Person);

        }
    }
}
