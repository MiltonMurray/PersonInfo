using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Models;
using System.Data;

namespace PServices

{
    public class CollegeService : IPersonInterface<College>
    {
        public void Add(College add)
        {
            new CollegeData().Add(add);
        }

        public void Delete(int id)
        {
            new CollegeData().Delete(id);
        }

        public List<College> SelectAll()
        {
            List<College> collegeList = new List<College>();         
            DataTable dt =  new CollegeData().SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                collegeList.Add(new College(row));
            }
            return collegeList;
        }

        public void Update(College update)
        {
            new CollegeData().Update(update);
        }
    }
}
