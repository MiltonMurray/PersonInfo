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
    class EmployeeService : Services, IPersonInterface<Employee>
    {
        public void Add(Employee add)
        {
            new EmployeeData().Add(add);
        }

        public void Update(Employee update)
        {
            new EmployeeData().Update(update);
        }

        List<Employee> IPersonInterface<Employee>.SelectAll()
        {
            List<Employee> empList = new List<Employee>();
            DataTable dt = new EmployeeData().SelectAll();
            foreach (DataRow dr in dt.Rows)
            {
                empList.Add(new Employee(dr));
            }
            return empList;
        }
    }
}
