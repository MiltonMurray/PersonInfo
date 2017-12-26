using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Models
{
   public class Person
   {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int SSN { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        public Person() {}
        public Person(int id, string lname, string fname, int ssn, DateTime dob, Gender gender, MaritalStatus mstat)
        {
            ID = id;
            LastName = lname;
            FirstName = fname;
            SSN = ssn;
            DOB = dob;
            Gender = gender;
            MaritalStatus = mstat;
        }

        public Person(Person p)
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
            ID = (int)dr["ID"];
            LastName = dr["Last Name"].ToString();
            FirstName = dr["First Name"].ToString();
            SSN = (int)dr["Social Security #"];
            DOB = (DateTime)dr["Date of Birth"];
            Gender = (Gender)(dr["Gender"]);
            MaritalStatus = (MaritalStatus)dr["Marital Status"];
        }
   }
   public class Student
    {
        public College college { get; set; }
        public DateTime date_start { get; set; }
        public int college_year { get; set; }
        public int avgHours { get; set; }


    }
    public class Employee
    {
        public DateTime date_hired { get; set; }
        public Department department { get; set; }
        public Member member { get; set; }



    }
}
