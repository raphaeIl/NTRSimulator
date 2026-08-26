using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;

namespace NTRSimulator.GameServer.Services
{
    public sealed class BackgroundService(
        IBackgroundRepository backgroundRepository,
        IAccountService accountService,
        ITableService tableService) : IBackgroundService
    {
        public const uint DefaultBackgroundId = 1001;

        public void AddAllBackgrounds(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            List<CommandBackgroundData> backgroundData = tableService.GetTable<CommandBackgroundData>();
            var existingBackgroundIds = new HashSet<uint>(account.Backgrounds.Select(b => b.BackgroundId));

            var newBackgrounds = backgroundData
                .Where(d => d.Id != 0 && !existingBackgroundIds.Contains(d.Id))
                .Select(d => new BackgroundEntity
                {
                    BackgroundId = d.Id,
                })
                .ToList();

            account.AddBackgrounds(newBackgrounds);
            backgroundRepository.SaveChanges();
        }

        public BackgroundEntity[] GetPlayerBackgrounds(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.Backgrounds.ToArray();
        }

        public uint GetCurrentBackground(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            return account.BackgroundId == 0 ? DefaultBackgroundId : account.BackgroundId;
        }

        public void SetCurrentBackground(uint accountUid, uint backgroundId)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.BackgroundId = backgroundId;
            backgroundRepository.SaveChanges();
        }

        public void AddBackground(uint accountUid, BackgroundEntity background)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            account.Backgrounds.Add(background);
            backgroundRepository.SaveChanges();
        }

        public bool RemoveBackground(uint accountUid, BackgroundEntity background)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");
            if (!account.Backgrounds.Remove(background))
                return false;

            backgroundRepository.SaveChanges();
            return true;
        }
    }

    public interface IBackgroundService : IGameService
    {
        BackgroundEntity[] GetPlayerBackgrounds(uint accountUid);
        uint GetCurrentBackground(uint accountUid);
        void SetCurrentBackground(uint accountUid, uint backgroundId);
        void AddBackground(uint accountUid, BackgroundEntity background);
        bool RemoveBackground(uint accountUid, BackgroundEntity background);
        void AddAllBackgrounds(uint accountUid);
    }
}
