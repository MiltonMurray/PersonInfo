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
           return GetData("dbo.usp_MM_Order_Person").Tables[0];
        }
        public void Update (Person p)
        {
            ExecuteProc("dbo.usp_MM_Update", PersonCo(p));
        }
        public void Delete (int id)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });
            ExecuteProc("dbo.usp_MM_Delete", paramList);
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
            paramList.Add(new SqlParameter("@Gender", SqlDbType.Int) { Value = p.Gender });
            paramList.Add(new SqlParameter("@MaritalStatus", SqlDbType.Int) { Value = p.MaritalStatus });
            if (p.ID > 0)
            {
                paramList.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = p.ID });
            }
            return paramList;
        }
    }
}
