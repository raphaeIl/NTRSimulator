using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SimCombatWeekHandler : SimCombatWeekHandlerBase
    {
        public override void HandleSimCombatWeekInfo(CS_SimCombatWeekInfo request, Connection connection)
        {
                    SC_SimCombatWeekInfo response = new SC_SimCombatWeekInfo
                    {
                        Field2 = 4,
                        Field3 = false,
                        Field1 = new SC_SimCombatWeekInfo_F1Type
                        {
                            Field1 = 10004,
                            Field2 = 1,
                            Field3 = 0,
                            Field5 = { },
                            Field10 = { },
                            Field13 = 0,
                            Field17 = new SC_SimCombatWeekInfo_F1Type_F17Type
                            {
                                Field9 = 0,
                                Field12 = 0,
                                Field15 = 0,
                                Field1 = { },
                                Field16 = false,
                            },
                            Field18 = 0,
                            Field20 = { },
                            Field21 = { },
                            Field22 = { },
                            Field23 = false,
                            Field24 = false,
                            Field26 = 0,
                            Field27 = false,
                            Field28 = false,
                        },
                    };
                    foreach (uint weekId in new uint[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 })
                    {
                        response.Field1.Field25[weekId] = new SC_SimCombatWeekInfo_F1Type_F25ValueType
                        {
                            Field1 = weekId,
                            Field2 = 0,
                            Field3 = 0,
                            Field4 = 0,
                            Field5 = { },
                            Field6 = { },
                            Field7 = weekId,
                            Field8 = 0,
                            Field9 = { },
                        };
                    }
                    connection.Send(response);
        }

    }
}
