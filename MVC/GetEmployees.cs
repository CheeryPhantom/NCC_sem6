
using MVC.Models;

namespace MVC
{
    public class GetEmployees
    {

        private List<EmployeeModel> employeeList = new List<EmployeeModel>();

        public GetEmployees()
        {
            employeeList.Add(
                new EmployeeModel { ID = 1, Name = "Bill Gates", Address = "Patan", Dept_ID = 1 }
            );
            employeeList.Add(
                new EmployeeModel { ID = 2, Name = "Jeff Bezos", Address = "Pokhara", Dept_ID = 2 }
            );
        }

        public List<EmployeeModel> GetEmployeeList()
        {
            return employeeList;
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return employeeList.Find(emp => emp.ID == id);
        }

        public int addEmployee(EmployeeModel employee)
        {

            employeeList.Add(employee);
            return employee.ID;
        }
    }
}
