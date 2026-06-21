using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;

namespace NTRSimulator.Database.Services
{
    public interface IAccountService
    {
        Account? GetByUid(uint accountUid);
        Account? GetByEmail(string email);
        Account CreateAccount(string email, string passwordHash, bool isGuest, DateTime nowUtc);
        void UpdateLastLogin(Account account, DateTime nowUtc);
    }

    public sealed class AccountService(IAccountRepository accountRepository) : IAccountService
    {
        public Account? GetByUid(uint accountUid)
        {
            return accountRepository.GetByUid(accountUid);
        }

        public Account? GetByEmail(string email)
        {
            return accountRepository.GetByEmail(email);
        }

        public Account CreateAccount(string email, string passwordHash, bool isGuest, DateTime nowUtc)
        {
            var account = new Account
            {
                Email = email,
                PasswordHash = passwordHash,
                IsGuest = isGuest,
                TimeCreated = nowUtc,
                TimeLastLogin = nowUtc,
            };

            accountRepository.Add(account);
            accountRepository.SaveChanges();
            return account;
        }

        public void UpdateLastLogin(Account account, DateTime nowUtc)
        {
            account.TimeLastLogin = nowUtc;
            accountRepository.SaveChanges();
        }
    }
}
