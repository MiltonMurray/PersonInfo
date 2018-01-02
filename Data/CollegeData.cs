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
            ExecuteProc("dbo.usp_MM_Ins_College", CollegeCo(c));
        }
        public DataTable SelectAll()
        {
            return GetData("dbo.usp_MM_Order_College").Tables[0];
        }
        public void Update(College c)
        {
            ExecuteProc("dbo.usp_MM_Upd_Col", CollegeCo(c));
        }
       
        public void Delete(int id)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });
            
            ExecuteProc("dbo.usp_MM_Del_Col", paramList);
        }

        
        public List<SqlParameter> CollegeCo(College c)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();          
            paramList.Add(new SqlParameter("@Name", SqlDbType.VarChar) { Value = c.Name });
            paramList.Add(new SqlParameter("@Street", SqlDbType.VarChar) { Value = c.Street});
            paramList.Add(new SqlParameter("@City", SqlDbType.VarChar) { Value = c.City });
            paramList.Add(new SqlParameter("@State", SqlDbType.Int) { Value = c.State }); 
            paramList.Add(new SqlParameter("@Zip", SqlDbType.Int) { Value = c.Zip });
            if (c.ID > 0)
            {
                paramList.Add(new SqlParameter("@CollegeID", SqlDbType.Int) { Value = c.ID });
            }
            return paramList;
        }
    }
}
