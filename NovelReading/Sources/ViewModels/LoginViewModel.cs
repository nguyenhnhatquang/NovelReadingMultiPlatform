using CommunityToolkit.Mvvm.ComponentModel;
using NovelReading.Sources.Models;
using NovelReading.Sources.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NovelReading.Sources.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        private IAuthService _authService;
        private AuthModel _authModel;
        public AuthModel AuthDataModel
        {
            get { return _authModel; }
            set { SetProperty(ref _authModel, value); }
        }

        public ICommand LoginCommand { get; }
        public ICommand ForgotPasswordCommand { get; }

        public LoginViewModel(IAuthService authService)
        {
            _authService = authService;
            //
            AuthDataModel = new AuthModel();
            LoginCommand = new Command(() => LoginAsync());
            ForgotPasswordCommand = new Command(() => ForgotPassword());
        }

        private async void LoginAsync()
        {
            if (await _authService.LoginAsync(AuthDataModel))
            {
                await Application.Current.MainPage.DisplayAlert("Alert", "Login Success", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Alert", "Login Failure", "OK");
            }
        }
        private async void ForgotPassword()
        {
            await Application.Current.MainPage.DisplayAlert("Alert", "ForgotPassword", "OK");
        }
    }
}
