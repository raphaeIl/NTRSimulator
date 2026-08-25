using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class DifficultHandler : DifficultHandlerBase
    {
        public override void HandleDifficultInfo(CS_DifficultInfo request, Connection connection)
        {
            connection.Send(new SC_DifficultInfo
            {
                Difficult = new SimCombatDifficult
                {
                    RaidTime = { },
                    Info = { },
                    TotalRaid = 0,
                    HCHEDDOPGLL = { },
                    IIJGACGAEAO = 0,
                },
            });
        }
    }
}
