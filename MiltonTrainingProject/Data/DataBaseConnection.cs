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
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM MM_PERSON", cn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "MM_Person");


            return ds;
        }

     
    }
}

