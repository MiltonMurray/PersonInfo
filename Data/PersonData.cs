using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace Data
{
    public class PersonData : DataBase
    {
        public void Add(Person p)
        {
            ExecuteProc("dbo.usp_MM_Insert", PersonCo(p));
        }
        public DataTable SelectAll()
        {
           return GetData("dbo.usp_MM_Order").Tables[0];
        }
        public void Update (Person p)
        {
            ExecuteProc("dbo.usp_MM_Insert", PersonCo(p));
        }
        /// <summary>
        /// Used to insert records into database
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="dob"></param>
        /// <param name="ssn"></param>
        /// <param name="gender"></param>
        /// <param name="mstat"></param>
        /// <returns></returns>
        public int Insert(string fname, string lname, DateTime dob, int ssn, string gender, string mstat)
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
        /// <param name="id"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="dob"></param>
        /// <param name="ssn"></param>
        /// <param name="gender"></param>
        /// <param name="mstat"></param>
        /// <returns></returns>
        public int Update(int id, string fname, string lname, DateTime dob, int ssn, string gender, string mstat)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("dbo.usp_MM_Update", conn);
            dCmd.CommandType = CommandType.StoredProcedure;

            dCmd.Parameters.AddWithValue("@ID", id);
            dCmd.Parameters.AddWithValue("@FirstName", fname);
            dCmd.Parameters.AddWithValue("@LastName", lname);
            dCmd.Parameters.AddWithValue("@DOB", dob);
            dCmd.Parameters.AddWithValue("@SSN", ssn);
            dCmd.Parameters.AddWithValue("@Gender", gender);
            dCmd.Parameters.AddWithValue("@MaritalStatus", mstat);
            return dCmd.ExecuteNonQuery();
            //TODO 
        }

        /// <summary>
        /// Delete record from database
        /// </summary>
        /// <param name="id"></param>
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

        /// <summary>
        /// Store Parameters
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public List<SqlParameter> PersonCo(Person p)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@FirstName", SqlDbType.VarChar) { Value = p.FirstName });
            paramList.Add(new SqlParameter("@LastName", SqlDbType.VarChar) { Value = p.LastName });
            paramList.Add(new SqlParameter("@DOB", SqlDbType.Date) { Value = p.DOB });
            paramList.Add(new SqlParameter("@SSN", SqlDbType.Int) { Value = p.SSN });
            paramList.Add(new SqlParameter("@Gender", SqlDbType.VarChar) { Value = p.Gender });
            paramList.Add(new SqlParameter("@MaritalStatus", SqlDbType.VarChar) { Value = p.MaritalStatus });
            if (p.ID > 0)
            {
                paramList.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = p.ID });
            }
            return paramList;
        }
    }
}
