using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiltonTrainingProject.Model;
using System.Data;

namespace MiltonTrainingProject.Model
{
    public class Person
    {
        int ID { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        int SSN { get; set; }
        DateTime DOB { get; set; }
        Gender Gender { get; set; }
        MaritalStatus MaritalStatus { get; set; }

        public Person(int id, string lname, string fname, int ssn, DateTime dob, Gender gender, MaritalStatus mstat )
        {
            ID = id;
            LastName = lname;
            FirstName = fname;
            SSN = ssn;
            DOB = dob;
            Gender = gender;
            MaritalStatus = mstat;
        }

        public Person (Person p)
        {
            ID = p.ID;
            LastName = p.LastName;
            FirstName = p.FirstName;
            SSN = p.SSN;
            DOB = p.DOB;
            Gender = p.Gender;
            MaritalStatus = p.MaritalStatus;
        }

        public Person(DataRow dr)
        {
            ID = (int)dr["PersonID"];
            LastName = dr["LastName"].ToString();
            FirstName = dr["FirstName"].ToString();
            SSN = (int)dr["SSN"];
            DOB = (DateTime)dr["DOB"];

        }
    }
}
