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
    public class Services : IPersonInterface<Person>
    {
        /// <summary>
        /// Add Person
        /// </summary>
        /// <param name="p"></param>
        public void Add(Person p)
        {
            new PersonData().Add(p);
        }

        /// <summary>
        /// Updates database
        /// </summary>
        /// <param name="p"></param>
        public void Update(Person p)
        {
            new PersonData().Update(p);
        }

        /// <summary>
        /// Collects all the data into a list
        /// </summary>
        /// <returns></returns>
        public List<Person> SelectAll()
        {
            List<Person> personList = new List<Person>();
            DataTable dt = new PersonData().SelectAll();
            foreach (DataRow dr in dt.Rows)
            {
                personList.Add(new Person(dr));
            }
            return personList;
        }
        
        /// <summary>
        /// Delete row in database
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            new PersonData().Delete(id);
        }
    }
}
