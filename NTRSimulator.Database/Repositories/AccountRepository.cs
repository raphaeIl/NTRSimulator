using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class AccountRepository(NTRSimulatorDbContext db) : Repository<AccountEntity>(db), IAccountRepository
    {
        public AccountEntity? GetByEmail(string email)
        {
            return Db.Accounts.SingleOrDefault(a => a.Email == email);
        }

        public AccountEntity? GetByUid(uint uid)
        {
            return Db.Accounts.SingleOrDefault(a => a.Uid == uid);
        }
    }

    public interface IAccountRepository : IRepository<AccountEntity>
    {
        AccountEntity? GetByEmail(string email);
        AccountEntity? GetByUid(uint uid);
    }
}
