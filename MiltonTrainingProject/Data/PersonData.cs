using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MiltonTrainingProject.Data
{
    class PersonData : DataBaseConnection
    {
        public static void Update(SqlDataAdapter ad, DataSet ds)
        {
            ad.Update(ds.Tables[0]);
        }
    }
}
