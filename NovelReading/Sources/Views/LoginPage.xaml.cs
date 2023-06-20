namespace NovelReading.Sources.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

        Preferences.Default.Set<bool>("AuthState", true);
    }
}