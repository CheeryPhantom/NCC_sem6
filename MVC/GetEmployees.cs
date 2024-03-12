using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC
{
    public class GetEmployees
    {
        static List<EmployeeModel> employees = new List<EmployeeModel>();

        public GetEmployees()
        {
            employees.Clear();
            employees.Add(
                new EmployeeModel { ID = 1, Name = "Bill Gates", Address = "Patan", Dept_ID = 1 }
            );
            employees.Add(
                new EmployeeModel { ID = 2, Name = "Jeff Bezos", Address = "Pokhara", Dept_ID = 2 }
            );
        }

        public List<EmployeeModel> GetEmployeeList()
        {
            return employees;
        }
    }
}
