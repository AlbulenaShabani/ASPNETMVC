using Silicon.Models;

namespace Silicon.ViewModel;

public class SignInViewModel
{
    public string Title { get; set; } = "Sign in";
    public SignInModel Form { get; set; } = new SignInModel();
}
