using Silicon.Models;

namespace Silicon.ViewModel;

public class SignUpViewModel
{
    public string Title { get; set; } = "SignUp";
    public SignUpModel Form { get; set; } = new SignUpModel();

}
