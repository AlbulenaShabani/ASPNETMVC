using Microsoft.AspNetCore.Mvc;

namespace Silicon.Controllers
{
	public class AccountDetailsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
