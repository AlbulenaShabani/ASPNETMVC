using Microsoft.AspNetCore.Mvc;
using Silicon.ViewModels;

namespace Silicon.Controllers;

public class AccountDetailsController : Controller
{
	[HttpGet]
	public IActionResult Index()
	{

		return View();
	}


	[HttpPost]
	public IActionResult Index(AccountDetailsUserViewModel viewModel)
	{
		if (!ModelState.IsValid)
		{
			return View(viewModel);
		}
		return RedirectToAction("Index", "AccountDetails");
	}
}
