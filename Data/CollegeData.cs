using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Data;
using System.Data.SqlClient;
using System.Data;

namespace Data
{
    public class CollegeData : DataBase
    {
        public void Add(College c)
        {
            ExecuteProc("dbo.usp_MM_Insert", CollegeCo(c));
        }
        public DataTable SelectAll()
        {
            return GetData("dbo.usp_MM_Order_Person").Tables[0];
        }
        public void Update(College p)
        {
            ExecuteProc("dbo.usp_MM_Update", CollegeCo(p));
        }
        public void Delete(int id)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });
            ExecuteProc("dbo.usp_MM_Delete", paramList);
        }
        public List<SqlParameter> CollegeCo(College c)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@CollegeID", SqlDbType.VarChar) { Value = c.ID });
            paramList.Add(new SqlParameter("@CollegeName", SqlDbType.VarChar) { Value = c.Name });
            paramList.Add(new SqlParameter("@Street", SqlDbType.VarChar) { Value = c.Street});
            paramList.Add(new SqlParameter("@City", SqlDbType.VarChar) { Value = c.City });
            paramList.Add(new SqlParameter("@State", SqlDbType.VarChar) { Value = c.State });
            paramList.Add(new SqlParameter("@ZIP", SqlDbType.VarChar) { Value = c.Zip });
            return paramList;
        }
    }
}
