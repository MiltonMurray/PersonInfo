using System;
using System.Windows.Forms;
using Models;
using PServices;
using System.Collections.Generic;

namespace MiltonTrainingProject
{
    public static class UIWork
    {
       
        /// <summary>
        /// Adds an Employee to a Grid
        /// </summary>
        public static void AddPersonToGrid(this DataGridView g, PersonModel p)
        {
           
            g.Rows[g.Rows.Add(p.LastName, 
                                p.FirstName, 
                                p.DOB.ToShortDateString(), 
                                p.SSN,
                                Enum.GetName(typeof(Gender), 
                                p.Gender), 
                                Enum.GetName(typeof(MaritalStatus), 
                                p.MaritalStatus))].Tag = p.ID;
        }
        /// <summary>
        /// Adds an Employee Collection to a Grid
        /// </summary>
        public static void AddPersonToGrid(this DataGridView g, List<PersonModel> person)
        {
            foreach (PersonModel p in person)
            {
                g.AddPersonToGrid(p);
            }
        }
        public static void AddEmployeeToGrid(this DataGridView g, Employee e)
        {

            g.Rows[g.Rows.Add(e.LastName
                                , e.FirstName
                                , e.DOB.ToShortDateString()
                                , e.SSN
                                , Enum.GetName(typeof(Gender), e.Gender)
                                , Enum.GetName(typeof(MaritalStatus), e.MaritalStatus)
                                , e.Date_hired.ToShortDateString()
                                , Enum.GetName(typeof(Department), e.Department)
                                , Enum.GetName(typeof(Member), e.Member)
                                )].Tag = e.ID;
        }
        public static void AddEmployeeToGrid(this DataGridView g, List<Employee> employee)
        {
            foreach (Employee e in employee)
            {
                g.AddEmployeeToGrid(e);
            }
        }
        public static void AddStudentToGrid(this DataGridView g, Student s)
        {
            g.Rows[g.Rows.Add(s.LastName
                                , s.FirstName
                                , s.DOB.ToShortDateString()
                                , s.SSN
                                , Enum.GetName(typeof(Gender), s.Gender)
                                , Enum.GetName(typeof(MaritalStatus), s.MaritalStatus)
                                , s.College
                                , s.AvgHours
                                , Enum.GetName(typeof(CollegeYear), s.College_year)
                                , s.Date_start.ToShortDateString()
                                , s.HasLoans == true ? "Yes" : "No"
                                )].Tag = s.ID;
        }
        public static void AddStudentToGrid(this DataGridView g, List<Student> student)
        {
            foreach (Student s in student)
            {
                g.AddStudentToGrid(s);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="c"></param>
        public static void AddCollegeToGrid(this DataGridView g, College c)
        {
            g.Rows[g.Rows.Add(c.Name, c.Street, c.City, Enum.GetName(typeof(State), c.State), c.Zip)].Tag = c.ID;
        }

        /// <summary>
        /// Adds a Collection of Colleges to a Grid
        /// </summary>
        public static void AddCollegeToGrid(this DataGridView g, List<College> colleges)
        {
            foreach (College c in colleges)
            {
                g.AddCollegeToGrid(c);
            }
        }
    
    public static void AddItemsToBox(this ComboBox cb, string[] names, int[] values)
        {
            
            for (int i = 0; i < names.Length; i++)
            {
                cb.Items.Add(new ComboBoxItem(names[i], values[i]));
               
            }
        }

        /// <summary>
        /// Adds list of colleges to a combobox
        /// </summary>
        public static void AddCollegesToBox(this ComboBox cb, List<College> collegeList)
        {
            foreach (College c in collegeList)
            {
                cb.Items.Add(c);
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }

            public ComboBoxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }
        }
        public static PersonModel GetPersonFromGrid(this DataGridViewRow row)
        {
            PersonModel p = new PersonModel();
            p.ID = (int)row.Tag;
            p.LastName = row.Cells[1].Value.ToString();
            p.FirstName = row.Cells[0].Value.ToString();           
            p.SSN = (int)row.Cells[3].Value;
            p.DOB = Convert.ToDateTime(row.Cells[2].Value);
            p.Gender = row.Cells[4].Value.ToString().GetEnumFromString<Gender>();
            p.MaritalStatus = row.Cells[5].Value.ToString().GetEnumFromString<MaritalStatus>();            
            return p;
        }
        public static Employee GetEmployeeFromGrid(this DataGridViewRow row)
        {
            Employee e = new Employee();
            e.ID = (int)row.Tag;
            e.LastName = row.Cells[1].Value.ToString();
            e.FirstName = row.Cells[0].Value.ToString();
            e.SSN = (int)row.Cells[3].Value;
            e.DOB = Convert.ToDateTime(row.Cells[2].Value);
            e.Gender = row.Cells[4].Value.ToString().GetEnumFromString<Gender>();
            e.MaritalStatus = row.Cells[5].Value.ToString().GetEnumFromString<MaritalStatus>();
            e.Date_hired = Convert.ToDateTime(row.Cells[6].Value);
            e.Department = row.Cells[7].Value.ToString().GetEnumFromString<Department>();
            e.Member = row.Cells[8].Value.ToString().GetEnumFromString<Member>();
            return e;
        }
        public static Student GetStudentFromGrid(this DataGridViewRow row)
        {
            Student s = new Student();
            s.ID = (int)row.Tag;
            s.LastName = row.Cells[1].Value.ToString();
            s.FirstName = row.Cells[0].Value.ToString();
            s.SSN = (int)row.Cells[3].Value;
            s.DOB = Convert.ToDateTime(row.Cells[2].Value);
            s.Gender = row.Cells[4].Value.ToString().GetEnumFromString<Gender>();
            s.MaritalStatus = row.Cells[5].Value.ToString().GetEnumFromString<MaritalStatus>();
            s.College = (College)row.Cells[6].Value;
            s.AvgHours = (int)row.Cells[7].Value;
            s.College_year = row.Cells[8].Value.ToString().GetEnumFromString<CollegeYear>();
            s.Date_start = Convert.ToDateTime(row.Cells[9].Value);            
            s.HasLoans = row.Cells[10].Value.ToString() == "Yes" ? true : false;
            return s;
        }
        public static College GetCollegeFromGrid(this DataGridViewRow row)
        {
            College c = new College();
            c.ID = (int)row.Tag;
            c.Name = row.Cells[0].Value.ToString();
            c.Street = row.Cells[1].Value.ToString();
            c.City = row.Cells[2].Value.ToString();
            c.Zip = (int)row.Cells[4].Value;
            c.State = row.Cells[3].Value.ToString().GetEnumFromString<State>();

            return c;
        }
        

    }
}
