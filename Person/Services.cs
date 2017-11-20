using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace Person
{
    //Buisness Access Layer
    public class Services
    {
        public Services() { }

        /// <summary>
        /// insert records into database
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public int Insert(string fname, string lname, DateTime dob, Int32 ssn, string gender, string mstat)
        {
            DataBase data = new DataBase();
           
            return data.Insert(fname, lname, dob, ssn, gender, mstat);          
                
          
        }


        /// <summary>
        /// Update records into database
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public int Update(int personID, string firstName)
        {
            DataBase data = new DataBase();
            return data.Update(personID, firstName);

        }

        /// <summary>
        /// Load records from database
        /// </summary>
        /// <returns></returns>
        public DataSet GetConnection
        {
            get { return Load(); }
        }
        private DataSet Load()
        {
            DataBase data = new DataBase();
          
            return data.Load();
          
        }

        /// <summary>
        /// Delete record from database
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
       
        public int Delete(int personID)
        {
            DataBase data = new DataBase();
           
            return data.Delete(personID);
            
            
        }
    }
}
