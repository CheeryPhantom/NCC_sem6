using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC
{
    public class Department
    {
        static List<DepartmentModel> departments = new List<DepartmentModel>();

        public Department()
        {
            departments.Add(
                new DepartmentModel { Dept_ID = 1, Dept_Name = "CSIT" }
            );
            departments.Add(
                new DepartmentModel { Dept_ID = 2, Dept_Name = "Physics" }
            );
            departments.Add(
                new DepartmentModel { Dept_ID = 3, Dept_Name = "Microbiology" }
            );
        }

        public List<DepartmentModel> GetDeparmentsList()
        {
            return departments;
        }

        public DepartmentModel GetDepartmentById(int id)
        {
            return departments.Find(dep => dep.Dept_ID == id);
        }
    }
}
