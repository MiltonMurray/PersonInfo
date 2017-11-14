using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltonTrainingProject.Data
{
    class DataBaseConnection
    {
        /**
         * DataSet is a grid that holds the data from our table. Each row in the DataSet grid will hold a row from our database table
         * */
        public DataSet GetConnection
        {

            get { return MyDataSet(); }

        }

        private DataSet MyDataSet()
        {
            string cs = "Data Source = sql_dev; Initial Catalog = INTERN_TEST; Integrated Security = True";

            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter ad = new SqlDataAdapter("SELECT fname, lname, ssn, dob, gender, mstat FROM MM_PERSON", cn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "MM_Person");

            //DataRow row = ds.Tables[0].NewRow();
            //row[1] = txtFirstName.Text;
            //row[2] = txtLastName.Text;
            //row[3] = Convert.ToDateTime(dPicker.Text);
            //row[4] = Int32.Parse(txtSSN.Text);
            //row[5] = cbGender.Text;
            //row[6] = cbMaritalStatus.Text;

            //ds.Tables[0].Rows.Add(row);
            //ad.Update(ds.Tables[0]);

            return ds;
        }

     
    }
}

