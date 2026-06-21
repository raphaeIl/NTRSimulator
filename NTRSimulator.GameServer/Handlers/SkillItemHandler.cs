using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SkillItemHandler : SkillItemHandlerBase
    {
        public override void HandleGetDelTalentSkillItems(CS_GetDelTalentSkillItems request, Connection connection)
        {
            connection.Send(new SC_GetDelTalentSkillItems());
        }
    }
}
