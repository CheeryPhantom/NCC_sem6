using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    public class DepartmentModel
    {
        [Key]
        public int Dept_ID { get; set; }
        public string? Dept_Name { get; set; }

    }
}