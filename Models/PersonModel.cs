using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Models
{
   public class PersonModel
   {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int SSN { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        public PersonModel() {}
        public PersonModel(int id, string lname, string fname, int ssn, DateTime dob, Gender gender, MaritalStatus mstat)
        {
            ID = id;
            LastName = lname;
            FirstName = fname;
            SSN = ssn;
            DOB = dob;
            Gender = gender;
            MaritalStatus = mstat;
        }

        public PersonModel(PersonModel p)
        {
            ID = p.ID;
            LastName = p.LastName;
            FirstName = p.FirstName;
            SSN = p.SSN;
            DOB = p.DOB;
            Gender = p.Gender;
            MaritalStatus = p.MaritalStatus;
        }

        public PersonModel(DataRow dr)
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
   public class PersonList : List<PersonModel> {
        //not yet implemented
    }

   public class Student : PersonModel
    {
        public int StuID {
             get { return StuID; }
             set { StuID = ID; }
        }
        public College College { get; set; }
        public DateTime Date_start { get; set; }
        public CollegeYear College_year { get; set; }
        public int AvgHours { get; set; }
        public bool HasLoans { get; set; }

        public Student() { }
        public Student(College college, DateTime date_start, CollegeYear college_year, int avgHours, bool hasLoans)
        {
            College = college;
            Date_start = date_start;
            College_year = college_year;
            AvgHours = avgHours;
            HasLoans = hasLoans;
        }

        public Student(Student s)
        {
            College = s.College;
            Date_start = s.Date_start;
            College_year = s.College_year;
            AvgHours = s.AvgHours;
            HasLoans = s.HasLoans;
        }

        public Student(DataRow dr)
        {
            College = (College)dr["College"];
            Date_start = (DateTime)dr["Date Started"];
            College_year = (CollegeYear)dr["College Year"];
            AvgHours = (int)dr["Average hours"];
            HasLoans = (bool)dr["Has Loans"];
        }


    }
    public class Employee : PersonModel
    {
        public int EmpID
        {
            get { return EmpID; }
            set { EmpID = ID; }
        }
        public DateTime Date_hired { get; set; }
        public Department Department { get; set; }
        public Member Member { get; set; }

        public Employee() { }
        public Employee(PersonModel p,DateTime date_hired, Department department, Member member) :base(p)
        {
            Date_hired = date_hired;
            Department = department;
            Member = member;
        }

        public Employee(Employee e)
        {
            Date_hired = e.Date_hired;
            Department = e.Department;
            Member = e.Member;
        }

        public Employee(DataRow dr) : base(dr)
        {
            Date_hired = (DateTime)dr["Date Hired"];
            Department = (Department)dr["Department"];
            Member = (Member)dr["Gym Member"];
        }

    }
}
