using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;

namespace NTRSimulator.Database.Services
{
    public interface IAccountService
    {
        AccountEntity? GetByUid(uint accountUid);
        AccountEntity? GetByEmail(string email);
        AccountEntity CreateAccount(string email, string passwordHash, bool isGuest, DateTime nowUtc);
        void UpdateLastLogin(AccountEntity account, DateTime nowUtc);
    }

    public sealed class AccountService(IAccountRepository accountRepository) : IAccountService
    {
        public AccountEntity? GetByUid(uint accountUid)
        {
            return accountRepository.GetByUid(accountUid);
        }

        public AccountEntity? GetByEmail(string email)
        {
            return accountRepository.GetByEmail(email);
        }

        public AccountEntity CreateAccount(string email, string passwordHash, bool isGuest, DateTime nowUtc)
        {
            var account = new AccountEntity
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

        public void UpdateLastLogin(AccountEntity account, DateTime nowUtc)
        {
            account.TimeLastLogin = nowUtc;
            accountRepository.SaveChanges();
        }
    }
}
