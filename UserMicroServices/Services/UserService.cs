using ProductMicroservice.Services.Interface;

namespace ProductMicroservice.Services
{
    public class UserService : IUserService
    {
        private static readonly string[] names = new[]
        {
            "abc", "xyz", "pqr"
        };
        public UserService()
        {
        }
        public IEnumerable<string> GetUsernames()
        {
            return names.ToList();
        }
    }
}
