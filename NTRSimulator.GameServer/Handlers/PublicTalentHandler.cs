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
                PublicSkillItems =
                {
                    new PublicSkillItem
                    {
                        Id = 1843288605358841857UL,
                        StcId = 91025,
                        GunId = 0,
                        Locked = 0,
                        MDFIDAFPBJN = false
                    },
                    new PublicSkillItem
                    {
                        Id = 1843288605358841858UL,
                        StcId = 93007,
                        GunId = 0,
                        Locked = 0,
                        MDFIDAFPBJN = false
                    },
                    new PublicSkillItem
                    {
                        Id = 1843288605358841856UL,
                        StcId = 91021,
                        GunId = 0,
                        Locked = 0,
                        MDFIDAFPBJN = false
                    }
                }
            });
        }
    }
}
