using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Data
{
    //Data Access Layer
    public class DataBase
    {
        string connStr = "Data Source=sql_dev;Initial Catalog=INTERN_TEST;Integrated Security=True";

        public DataBase() { }
        /// <summary>
        /// Used to insert records into database
        /// </summary>
        /// <param name="ArtistName"></param>       
        /// <returns></returns>

        public int Insert(string fname, string lname, DateTime dob, int ssn, string gender, string mstat )
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("dbo.usp_MM_Insert", conn);
            dCmd.CommandType = CommandType.StoredProcedure;

            dCmd.Parameters.AddWithValue("@FirstName", fname);
            dCmd.Parameters.AddWithValue("@LastName", lname);
            dCmd.Parameters.AddWithValue("@DOB", dob);
            dCmd.Parameters.AddWithValue("@SSN", ssn);
            dCmd.Parameters.AddWithValue("@Gender", gender);
            dCmd.Parameters.AddWithValue("@MaritalStatus", mstat);
            return dCmd.ExecuteNonQuery();

        }


        /// <summary>
        /// Update record into database
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public int Update(string fname, string lname, DateTime dob, int ssn, string gender, string mstat)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("dbo.usp_MM_Edit", conn);
            dCmd.CommandType = CommandType.StoredProcedure;

            dCmd.Parameters.AddWithValue("@FirstName", fname);
            dCmd.Parameters.AddWithValue("@LastName", lname);
            dCmd.Parameters.AddWithValue("@DOB", dob);
            dCmd.Parameters.AddWithValue("@SSN", ssn);
            dCmd.Parameters.AddWithValue("@Gender", gender);
            dCmd.Parameters.AddWithValue("@MaritalStatus", mstat);
            return dCmd.ExecuteNonQuery();

        }

        /// <summary>
        /// Load all records from database
        /// </summary>
        /// <returns></returns>
        public DataSet Load()
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter ad = new SqlDataAdapter("dbo.usp_MM_Order_Person", conn);
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();

            ad.Fill(ds, "MM_Person");
            return ds;

        }

        /// <summary>
        /// Delete record from database
        /// </summary>
        /// <param name="ArtistID"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("dbo.usp_MM_Delete", conn);
            dCmd.CommandType = CommandType.StoredProcedure;

            dCmd.Parameters.AddWithValue("@ID", id);
            return dCmd.ExecuteNonQuery();



        }
    }
}
