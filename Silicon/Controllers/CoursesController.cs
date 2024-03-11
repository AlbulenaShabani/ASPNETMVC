using Microsoft.AspNetCore.Mvc;

namespace Silicon.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
