using NovelReading.Sources.Services;
using NovelReading.Sources.Services.Interface;

namespace NovelReading.Sources.Views;

public partial class LoadingPage : ContentPage
{
	private IAuthService _authService;
	public LoadingPage()
	{
        _authService = new AuthService();

        InitializeComponent();
	}

    private async void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        if (await _authService.IsAuthenticatedAsync())
        {
            // User is logged in
            // redirect to main page
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            // User is not logged in 
            // Redirect to LoginPage
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}