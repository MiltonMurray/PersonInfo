using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Models;


namespace Data
{
    //Data Access Layer
    public abstract class DataBase
    {
        protected static string connStr { get; private set; }
        static DataBase()
        {
            connStr = "Data Source=sql_dev;Initial Catalog=INTERN_TEST;Integrated Security=True"; //Access string
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connStr);
        }
     
        /// <summary>
        /// Load all records from database
        /// </summary>
        /// <returns></returns>
        protected static DataSet Load( string proc, List<SqlParameter> paramList)          
        {
            DataSet ds = new DataSet();
            try
            {
                
                using (SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand(proc, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter p in paramList)
                    {
                        cmd.Parameters.Add(p.ParameterName, p.SqlDbType).Value = p.Value;
                    }
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
            }catch { 
                throw;
            }
          
            return ds;
        }
        protected static DataSet GetData(string proc)
        {
            return Load(proc, new List<SqlParameter>());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proc"></param>
        /// <param name="paramList"></param>
        protected static void ExecuteProc(String proc, List<SqlParameter> paramList)
        {
            try
            {
                using (SqlConnection conn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand(proc, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter p in paramList)
                    {
                        cmd.Parameters.Add(p.ParameterName, p.SqlDbType).Value = p.Value;
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        protected static void ExecuteProc(string proc)
        {
            ExecuteProc(proc, new List<SqlParameter>());
        }
    }
}
