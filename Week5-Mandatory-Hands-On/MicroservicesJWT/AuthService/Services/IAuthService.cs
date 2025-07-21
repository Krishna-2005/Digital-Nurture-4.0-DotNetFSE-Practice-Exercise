namespace AuthService.Services
{
    public interface IAuthService
    {
        string GenerateToken(string username);
    }
}
