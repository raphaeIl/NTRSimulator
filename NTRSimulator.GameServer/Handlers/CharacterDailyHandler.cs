using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class CharacterDailyHandler : CharacterDailyHandlerBase
    {
        public override void HandleGetCharacterDailyInfo(CS_GetCharacterDailyInfo request, Connection connection)
        {
                    connection.Send(new SC_GetCharacterDailyInfo
                    {
                        Field1 = { },
                    });
        }

    }
}
