using NovelReading.Sources.Models;
using NovelReading.Sources.Services.Interface;

namespace NovelReading.Sources.Services
{
    public class AuthService : IAuthService
    {
        private const string AuthStateKey = "AuthState";

        public async Task<bool> IsAuthenticatedAsync()
        {
            await Task.Delay(2000);

            var authState = Preferences.Default.Get<bool>(AuthStateKey, false);

            return authState;
        }

        public async Task<bool> LoginAsync(AuthModel authModel)
        {
            await Task.Delay(2000);

            if (string.IsNullOrEmpty(authModel?.UserName) || string.IsNullOrEmpty(authModel?.Password))
            {
                return false;
            }

            Preferences.Set(AuthStateKey, true);

            var authState = Preferences.Default.Get<bool>(AuthStateKey, false);

            return authState;
        }

        public Task<bool> RegisterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPasswordAsync()
        {
            throw new NotImplementedException();
        }
    }
}
