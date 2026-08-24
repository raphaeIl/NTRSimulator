using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class AdjutantHandler : AdjutantHandlerBase
    {
        public override void HandleAdjutantInfo(CS_AdjutantInfo request, Connection connection)
        {
            connection.Send(new SC_AdjutantInfo
            {
                Adjutant = new MAFLHCANJBH
                {
                    Current = 0,
                    Costume = 0,
                    Assistants = { 10202, 0, 0, 0 },
                    Background = new BattleResult_2
                    {
                        PFFOLMNDAGL = 1001,
                        PANKKABLKMH = 2001
                    }
                }
            });
        }
    }
}
