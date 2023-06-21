using CommunityToolkit.Mvvm.ComponentModel;

namespace NovelReading.Sources.Models
{
    public class AuthModel : ObservableObject
    {
        private string _username;
        private string _password;
        private string _passwordcf;

        public string UserName
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public string PasswordCf
        {
            get { return _passwordcf; }
            set { SetProperty(ref _passwordcf, value); }
        }
    }
}
