using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Data
{
    public class StudentData : PersonData
    {
        public void Add(Student s)
        {
            ExecuteProc("dbo.usp_MM_Insert", StudentCo(s));
        }

        public void Update(Student s)
        {
            ExecuteProc("dbo.usp_MM_Update", StudentCo(s));
        }
        public DataTable SelectAllStudents()
        {
            //Not YET IMPLEMENTED
            return null;
        }
        /// <summary>
        /// Store Parameters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<SqlParameter> StudentCo(Student s)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@FirstName", SqlDbType.VarChar) { Value = s.FirstName });
            paramList.Add(new SqlParameter("@LastName", SqlDbType.VarChar) { Value = s.LastName });
            paramList.Add(new SqlParameter("@DOB", SqlDbType.Date) { Value = s.DOB });
            paramList.Add(new SqlParameter("@SSN", SqlDbType.Int) { Value = s.SSN });
            paramList.Add(new SqlParameter("@Gender", SqlDbType.Int) { Value = s.Gender });
            paramList.Add(new SqlParameter("@MaritalStatus", SqlDbType.Int) { Value = s.MaritalStatus });
            paramList.Add(new SqlParameter("@College", SqlDbType.VarChar) { Value = s.College});
            paramList.Add(new SqlParameter("@DateStarted", SqlDbType.Date) { Value = s.Date_start});
            paramList.Add(new SqlParameter("@CollegeYear", SqlDbType.Int) { Value = s.College_year });
            paramList.Add(new SqlParameter("@AverageHours", SqlDbType.Int) { Value = s.AvgHours });
            paramList.Add(new SqlParameter("@HasLoans", SqlDbType.Bit) { Value = s.HasLoans });

            if (s.ID > 0)
            {
                paramList.Add(new SqlParameter("@StuID", SqlDbType.Int) { Value = s.StuID });
            }
            return paramList;
        }
    }
}
