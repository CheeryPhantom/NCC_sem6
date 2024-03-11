using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("[controller]")]
    public class DepartmentController : Controller
    {
        private Department department = new Department();

        public IActionResult Index()
        {

            return View(department.GetDeparmentsList());
        }
    }
}
