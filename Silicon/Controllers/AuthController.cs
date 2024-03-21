using Infrastructure.ServSices;
using Microsoft.AspNetCore.Mvc;
using Silicon.ViewModel;

namespace Silicon.Controllers;

public class AuthController(UserService userService) : Controller
{
    private readonly UserService _userService = userService;


	[HttpGet]
    [Route("/SignUp")]
    public IActionResult SignUp() => View(new SignUpViewModel());


    [HttpPost]
    [Route("/SignUp")]
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
            return RedirectToAction("Index", "Home");
        }

        return View(viewModel);
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
        return RedirectToAction("Index", "Courses");


    }
}
