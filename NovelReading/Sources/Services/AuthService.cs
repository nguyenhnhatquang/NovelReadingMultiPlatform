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
    }
}
