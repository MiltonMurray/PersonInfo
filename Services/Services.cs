using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data;
using Models;

namespace PServices
{
    //Buisness Access Layer
    public class Services
    {
        public void Add(Person p)
        {
            new PersonData().Add(p);
        }

        
        public void Update(Person p)
        {
            new PersonData().Update(p);
        }

        public List<Person> SelectAll()
        {
            List<Person> employeeList = new List<Person>();
            DataTable dt = new PersonData().SelectAll();
            foreach (DataRow dr in dt.Rows)
            {
                employeeList.Add(new Person(dr));
            }
            return employeeList;
        }


        /// <summary>
        /// Delete record from database
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>   
        public int Delete(int personID)
        {
            return personID;
        }

       

    }
}
