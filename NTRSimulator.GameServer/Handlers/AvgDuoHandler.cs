using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Table;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class AvgDuoHandler(ITableService tableService) : AvgDuoHandlerBase
    {
        public override void HandleGetLobbbyAvgDuoInfo(CS_GetLobbbyAvgDuoInfo request, Connection connection)
        {
            List<Avg3dDuoStageData> avg3dDuoStageData = tableService.GetTable<Avg3dDuoStageData>();

            SC_GetLobbbyAvgDuoInfo lobbyAvgDuoInfo = new SC_GetLobbbyAvgDuoInfo
            {
                // main plot
                Field1 = { },

                // sub plot
                Field2 = { }
            };

            foreach (Avg3dDuoStageData avg3dDuoStage in avg3dDuoStageData)
            {
                lobbyAvgDuoInfo.Field1[avg3dDuoStage.Field1] = true;

                foreach (uint avg3dDuoSubStage in avg3dDuoStage.Field2)
                {
                    lobbyAvgDuoInfo.Field2[avg3dDuoSubStage] = true;
                }
            }

            connection.SendAutoEncrypted(lobbyAvgDuoInfo);
        }
    }
}
