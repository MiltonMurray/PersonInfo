using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using Data;

namespace PServices
{
    class StudentService : Services, IPersonInterface<Student>
    {
        public void Add(Student add)
        {
            new StudentData().Add(add);
        }

        public void Update(Student update)
        {
            new StudentData().Update(update);
        }

        List<Student> IPersonInterface<Student>.SelectAll()
        {
            List<Student> studentList = new List<Student>();
            DataTable dt = new StudentData().SelectAll();
            foreach (DataRow dr in dt.Rows)
            {
                studentList.Add(new Student(dr));
            }
            return studentList;
        }
    }
}
