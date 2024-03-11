using Microsoft.AspNetCore.Mvc;
using Silicon.ViewModel;

namespace Silicon.Controllers;

public class AuthController : Controller
{
    [HttpGet]
    [Route("/SignUp")]
    public IActionResult SignUp()
    {
        ViewData["Title"] = "SignUp";
        return View();
    }

    [HttpPost]
    [Route("/SignUp")]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }
        return RedirectToAction("Index", "Home");
    }





    [HttpGet]
    [Route("/SignIn")]
    public IActionResult SignIn()
    {
        return View();
    }

    [HttpPost]
    [Route("/SignIn")]
    public IActionResult SignIn(SignInViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }
        return RedirectToAction("Courses", "Index");


    }
}
