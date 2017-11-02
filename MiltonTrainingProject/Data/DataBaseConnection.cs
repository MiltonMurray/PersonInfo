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
        SqlDataAdapter da_1; //opens up a table in a database

        public string Sql   //public access for variables
        {
            set { sql_string = value; }
        }
        public string connection_string
        {
            set { strCon = value; }
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

            da_1 = new SqlDataAdapter(sql_string, con); //grabs wanted data

            DataSet dat_set = new DataSet();
            da_1.Fill(dat_set, "Table_Data_1");
            con.Close();

            return dat_set;
        }

        public void UpdateDatabase(DataSet ds)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da_1);
            cb.DataAdapter.Update(ds.Tables[0]);
        }
    }
}

