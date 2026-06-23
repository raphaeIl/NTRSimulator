using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Database.Repositories;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class AvgDuoHandler(IAvgDuoRepository avgDuoRepository) : AvgDuoHandlerBase
    {
        public override void HandleGetLobbbyAvgDuoInfo(CS_GetLobbbyAvgDuoInfo request, Connection connection)
        {
            if (connection.Account == null) return;

            SC_GetLobbbyAvgDuoInfo lobbyAvgDuoInfo = new SC_GetLobbbyAvgDuoInfo
            {
                // main plot
                Field1 = { },

                // sub plot
                Field2 = { }
            };

            var avgDuo = avgDuoRepository.GetByUid(connection.Account.Uid);

            if (avgDuo != null)
            {
                foreach (uint avgDuoMainStageId in avgDuo.AvgDuoMainStageIds)
                {
                    lobbyAvgDuoInfo.Field1[avgDuoMainStageId] = true;
                }

                foreach (uint avgDuoSubStageId in avgDuo.AvgDuoSubStageIds)
                {
                    lobbyAvgDuoInfo.Field2[avgDuoSubStageId] = true;
                }
            }

            connection.SendAutoEncrypted(lobbyAvgDuoInfo);
        }
    }
}
