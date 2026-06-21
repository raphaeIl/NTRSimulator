using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Protocol;
using NTRSimulator.PcapParser;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class PublicTalentHandler : PublicTalentHandlerBase
    {
        public override void HandlePublicTalentSkillItems(CS_PublicTalentSkillItems request, Connection connection)
        {
            //SC_PublicTalentSkillItems scPublicTalentSkillItems = PcapUtils.GetPacketFromPcap<SC_PublicTalentSkillItems>(MsgId.MsgScPublicTalentSkillItems, PacketType.RESPONSE);

            connection.Send(new SC_PublicTalentSkillItems
            {
                Field1 =
                {
                    new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F12Type_F30Type_F8Type
                    {
                        Field1 = 1843288605358841857UL,
                        Field2 = 91025,
                        Field3 = 0,
                        Field4 = 0,
                        Field5 = false
                    },
                    new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F12Type_F30Type_F8Type
                    {
                        Field1 = 1843288605358841858UL,
                        Field2 = 93007,
                        Field3 = 0,
                        Field4 = 0,
                        Field5 = false
                    },
                    new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F12Type_F30Type_F8Type
                    {
                        Field1 = 1843288605358841856UL,
                        Field2 = 91021,
                        Field3 = 0,
                        Field4 = 0,
                        Field5 = false
                    }
                }
            });
        }
    }
}
