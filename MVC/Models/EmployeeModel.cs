using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    public class EmployeeModel
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        [ForeignKey("Department")]
        public int Dept_ID;
        public DepartmentModel Department;
    }
}
