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
            ExecuteProc("dbo.usp_MM_Insert", EmployeeCo(e));
        }
        
        public void Update(Employee e)
        {
            ExecuteProc("dbo.usp_MM_Update", EmployeeCo(e));
        }        

        public DataTable SelectAllEmployees()
        {
            //Not YET IMPLEMENTED
            return null;
        }
        /// <summary>
        /// Store Parameters
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public List<SqlParameter> EmployeeCo(Employee e)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@DateHird", SqlDbType.Date) { Value = e.Date_hired });
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
