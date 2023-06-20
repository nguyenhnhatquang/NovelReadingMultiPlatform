namespace NovelReading.Sources.Services.Interface
{
    public interface IAuthService
    {
        Task<bool> IsAuthenticatedAsync();
    }
}
