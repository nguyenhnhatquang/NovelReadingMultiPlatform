using NovelReading.Sources.Services;
using NovelReading.Sources.ViewModels;

namespace NovelReading.Sources.Views;

public partial class LoginPage : ContentPage
{
	private LoginViewModel _loginViewModel;
	public LoginPage()
	{
		InitializeComponent();
        //
        _loginViewModel = new LoginViewModel(new AuthService());
		BindingContext = _loginViewModel;
    }
}