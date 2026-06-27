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
                        ActivityId = 69998,
                        LKAHOENFDFN = new KBJGHCKJJAJ
                        {
                            JODLPGFGDDN = 1,
                            BPJMFIBFGKC = 1728668611,
                            StepReward = { },
                            IIOPIOOLBOA = false,
                        },
                    });
        }

    }
}
