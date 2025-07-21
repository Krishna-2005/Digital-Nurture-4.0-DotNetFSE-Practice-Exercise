using UserService.Services;

namespace UserService.Services
{
    public class UserService : IUserService
    {
        public string GetUserName()
        {
            return "Krishna"; // Or dynamic logic
        }
    }
}
