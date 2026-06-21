using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class BattlepassHandler : BattlepassHandlerBase
    {
        public override void HandleGetBattlepassInfo(CS_GetBattlepassInfo request, Connection connection)
        {
                    connection.Send(new SC_GetBattlepassInfo
                    {
                        Field1 = new SC_BattlepassAcquire_F2Type
                        {
                            Field1 = 0,
                            Field2 = { [1] = 0 },
                            Field3 = 0,
                            Field4 = 30034,
                            Field5 = 1,
                            Field6 = { 34001, 34002, 34003, 34004 },
                            Field7 = { 34013, 34009, 34015, 34010, 34012, 34016, 34007, 34014, 34008 },
                            Field8 = { },
                            Field9 = { },
                            Field11 = { },
                            Field12 = { },
                            Field13 = 0,
                            Field14 = false,
                            Field15 = { 34018, 34019, 34022, 34020, 34021, 34017 },
                        },
                        Field2 = 0,
                    });
        }

    }
}
