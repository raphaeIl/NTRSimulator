using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class NewbeeQuestHandler : NewbeeQuestHandlerBase
    {
        public override void HandleGetNewbeeQuestV2(CS_GetNewbeeQuestV2 request, Connection connection)
        {
                    connection.Send(new SC_GetNewbeeQuestV2
                    {
                        Field1 = 69998,
                        Field2 = new SC_GetNewbeeQuestV2_F2Type
                        {
                            Field1 = 1,
                            Field2 = 1728668611,
                            Field3 = { },
                            Field4 = false,
                        },
                    });
        }

    }
}
