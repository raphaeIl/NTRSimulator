using NTRSimulator.Database.Core;
using NTRSimulator.Database.Entities;

namespace NTRSimulator.Database.Repositories
{
    public sealed class AccountRepository(NTRSimulatorDbContext db) : Repository<Account>(db), IAccountRepository
    {
        public Account? GetByEmail(string email)
        {
            return Db.Accounts.SingleOrDefault(a => a.Email == email);
        }

        public Account? GetByUid(uint uid)
        {
            return Db.Accounts.SingleOrDefault(a => a.Uid == uid);
        }
    }

    public interface IAccountRepository : IRepository<Account>
    {
        Account? GetByEmail(string email);
        Account? GetByUid(uint uid);
    }
}
