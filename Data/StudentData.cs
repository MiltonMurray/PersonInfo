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
            ExecuteProc("dbo.usp_MM_Insert_Stu", StudentCo(s));
        }

        public void Update(Student s)
        {
            ExecuteProc("dbo.usp_MM_Upd_Stu", StudentCo(s));
        }

        public void Delete(Student s, int id)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });
            ExecuteProc("dbo.usp_MM_Del_Stu", paramList);
        }
        public DataTable Attendance(string name)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@CollegeName", SqlDbType.VarChar) { Value = name });


            return GetData("dbo.usp_MM_CollegeAttendance", paramList).Tables[0];

        }
        public DataTable SelectAllStudents()
        {
            return GetData("dbo.usp_MM_sel_stu").Tables[0];
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
            paramList.Add(new SqlParameter("@College", SqlDbType.VarChar) { Value = s.College.ToString()});
            paramList.Add(new SqlParameter("@DateStarted", SqlDbType.Date) { Value = s.Date_start});
            paramList.Add(new SqlParameter("@CollegeYear", SqlDbType.Int) { Value = s.College_year });
            paramList.Add(new SqlParameter("@AverageHours", SqlDbType.Int) { Value = s.AvgHours });
            paramList.Add(new SqlParameter("@HasLoans", SqlDbType.Bit) { Value = s.HasLoans});

            if (s.ID > 0)
            {
                paramList.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = s.ID });
            }
            return paramList;
        }
    }
}
