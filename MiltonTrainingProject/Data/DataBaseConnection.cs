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
        private string sql_string; //will hold a SQL string like "SELECT * FROM table" from the Settings
        private string strCon; //holds a location of the database
        SqlDataAdapter adapter; //opens up a table in a database

        public string Sql   //public access for variables
        {
            set { sql_string = "SELECT fname, lname, ssn, dob, gender, mstat FROM MM_PERSON"; }
        }
        public string connection_string
        {
            set { strCon = "Data Source = sql_dev; Initial Catalog = INTERN_TEST; Integrated Security = True"; }
        }

        /**
         * DataSet is a grid that holds the data from our table. Each row in the DataSet grid will hold a row from our database table
         * */
        public DataSet GetConnection
        {

            get { return MyDataSet(); }

        }

        private DataSet MyDataSet()
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            adapter = new SqlDataAdapter(sql_string, con); //grabs wanted data

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Table_Data_1");
            con.Close();

            return dataSet;
        }

        public void UpdateDatabase(DataSet ds)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            cb.DataAdapter.Update(ds.Tables[0]);
        }
    }
}

