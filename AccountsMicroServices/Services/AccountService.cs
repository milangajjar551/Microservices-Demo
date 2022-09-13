using ProductMicroservice.Services.Interface;

namespace ProductMicroservice.Services
{
    public class AccountService : IAccountService
    {
        private static readonly string[] Accounts = new[]
        {
            "admin", "employee", "client"
        };
        public AccountService()
        {
        }
        public IEnumerable<string> GetAccounts()
        {
            return Accounts.ToList();
        }
    }
}
