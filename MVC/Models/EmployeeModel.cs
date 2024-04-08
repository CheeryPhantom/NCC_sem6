using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class EmployeeModel
    {
        [Key]
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(25)]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Address is required!")]
        [StringLength(25)]
        public string? Address { get; set; }
        
        [Required(ErrorMessage = "Department needs to be selected!")]
        public int Dept_ID { get; set; }
    }
}
