using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class EmployeeData : PersonData
    {
        public void Add(Employee e)
        {
            ExecuteProc("dbo.usp_MM_Insert_Em", EmployeeCo(e));
        }
        
        public void Update(Employee e)
        {
            ExecuteProc("dbo.usp_MM_Update", EmployeeCo(e));
        }        

        public DataTable SelectAllEmployees()
        {
            return GetData("dbo.usp_MM_sel_emp").Tables[0];          
        }
        /// <summary>
        /// Store Parameters
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public List<SqlParameter> EmployeeCo(Employee e)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@FirstName", SqlDbType.VarChar) { Value = e.FirstName });
            paramList.Add(new SqlParameter("@LastName", SqlDbType.VarChar) { Value = e.LastName });
            paramList.Add(new SqlParameter("@DOB", SqlDbType.Date) { Value = e.DOB });
            paramList.Add(new SqlParameter("@SSN", SqlDbType.Int) { Value = e.SSN });
            paramList.Add(new SqlParameter("@Gender", SqlDbType.Int) { Value = e.Gender });
            paramList.Add(new SqlParameter("@MaritalStatus", SqlDbType.Int) { Value = e.MaritalStatus }); 
            paramList.Add(new SqlParameter("@DateHired", SqlDbType.Date) { Value = e.Date_hired });
            paramList.Add(new SqlParameter("@Department", SqlDbType.Int) { Value = e.Department });
            paramList.Add(new SqlParameter("@GymMember", SqlDbType.Int) { Value = e.Member });
            
            if (e.ID > 0)
            {
                paramList.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = e.EmpID });
            }
            return paramList;
        }
    }
}
