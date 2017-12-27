using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Data;
using System.Data;

namespace PServices
{
    public class EmployeeService : IPersonInterface<Employee>
    {
        public void Add(Employee add)
        {
            new EmployeeData().Add(add);
        }

        public void Update(Employee update)
        {
            new EmployeeData().Update(update);
        }

        public List<Employee> SelectAll()
        {
            List<Employee> empList = new List<Employee>();
            DataTable dt = new EmployeeData().SelectAllEmployees();
            foreach (DataRow dr in dt.Rows)
            {
                empList.Add(new Employee(dr));
            }
            return empList;
        }

        public void Delete(Employee e, int id)
        {
            new EmployeeData().Delete(e,id);
        }
    }
}
