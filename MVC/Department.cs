using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Models;

namespace MVC
{
    public class Department
    {
        public List<DepartmentModel> departments = new List<DepartmentModel>();
        public List<SelectListItem> dSO = new List<SelectListItem>();
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

        public List<SelectListItem> getDSO()
        {
            dSO = departments.Select(d => new SelectListItem //dSO = department select options
            {
                Value = d.Dept_ID.ToString(),
                Text = d.Dept_Name
            }).ToList();

            dSO.Insert(0, new SelectListItem
            {
                Value = null,
                Text = "Select an option"
            });

            return dSO;
        }
    }
}
