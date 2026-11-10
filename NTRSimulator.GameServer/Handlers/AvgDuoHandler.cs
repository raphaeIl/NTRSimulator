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
                JBLLPJFAIEJ = { },

                // sub plot
                KMJPFNBGAIM = { }
            };

            // 把主线 1-x 的战前剧情都标成"已看过"，让客户端跳过 AVG 直接进战斗
            // 命名规律：剧情 id = 关卡 id * 100 + 11（例如 10144 -> 1014411）
            foreach (uint s in new uint[] { 10101, 10102, 10103, 10104, 10105, 10106, 10107, 10108, 10109, 10110,
                                            10141, 10142, 10143, 10144, 10145, 10146, 10147, 10148, 10149,
                                            10183, 10184 })
            {
                lobbyAvgDuoInfo.JBLLPJFAIEJ[s * 100 + 11] = true;
            }

            var avgDuo = avgDuoRepository.GetByUid(connection.Account.Uid);

            if (avgDuo != null)
            {
                foreach (uint avgDuoMainStageId in avgDuo.AvgDuoMainStageIds)
                {
                    lobbyAvgDuoInfo.JBLLPJFAIEJ[avgDuoMainStageId] = true;
                }

                foreach (uint avgDuoSubStageId in avgDuo.AvgDuoSubStageIds)
                {
                    lobbyAvgDuoInfo.KMJPFNBGAIM[avgDuoSubStageId] = true;
                }
            }

            connection.SendAutoEncrypted(lobbyAvgDuoInfo);
        }
    }
}
