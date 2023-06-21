using NovelReading.Sources.Models;

namespace NovelReading.Sources.Services.Interface
{
    public interface IAuthService
    {
        Task<bool> IsAuthenticatedAsync();
        Task<bool> LoginAsync(AuthModel authModel);
        Task<bool> RegisterAsync();
        Task<bool> ForgotPasswordAsync();
    }
}
