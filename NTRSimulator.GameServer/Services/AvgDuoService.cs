using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;

namespace NTRSimulator.GameServer.Services
{
    public sealed class AvgDuoService(
        IAvgDuoRepository avgDuoRepository,
        IAccountService accountService,
        ITableService tableService) : IAvgDuoService
    {
        public void AddAllAvgDuo(uint accountUid)
        {
            var account = accountService.GetByUid(accountUid)
                ?? throw new InvalidOperationException($"Account with uid '{accountUid}' was not found.");

            Avg3dDuoStageData[] avg3dDuoStages = tableService.GetTable<Avg3dDuoStageData>().ToArray();

            var avgDuo = account.AvgDuo ?? new AvgDuo();
            avgDuo.AvgDuoMainStageIds = avg3dDuoStages
                .Select(stage => stage.Field1)
                .ToArray();
            avgDuo.AvgDuoSubStageIds = avg3dDuoStages
                .SelectMany(stage => stage.Field2)
                .ToArray();

            if (account.AvgDuo == null)
            {
                account.AvgDuo = avgDuo;
            }

            avgDuoRepository.SaveChanges();
        }
    }

    public interface IAvgDuoService : IGameService
    {
        void AddAllAvgDuo(uint accountUid);
    }
}
