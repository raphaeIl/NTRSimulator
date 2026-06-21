using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SimCombatUniteHandler : SimCombatUniteHandlerBase
    {
        public override void HandleSimCombatUniteInfo(CS_SimCombatUniteInfo request, Connection connection)
        {
            connection.Send(new SC_SimCombatUniteInfo
            {
                Field1 = new SC_SimCombatUniteInfo_F1Type
                {
                    Field1 =
                    {
                        {
                            1162u,
                            new SC_SimCombatUniteEnter_F1Type
                            {
                                Field1 = 1162,
                                Field2 = 0,
                                Field3 = 0,
                                Field4 = false,
                                Field5 = { },
                                Field6 = 0,
                                Field7 = { },
                                Field8 = 0,
                                Field9 = 90066,
                                Field10 = 0,
                            }
                        },
                    },
                },
            });
        }
    }
}
