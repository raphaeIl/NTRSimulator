using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class LobbyCharacterHandler : LobbyCharacterHandlerBase
    {
        public override void HandleLobbyCharacterInfo(CS_LobbyCharacterInfo request, Connection connection)
        {
            connection.Send(new SC_LobbyCharacterInfo
            {
                ALPKEDLGCBP =
                {
                    [10010301u] = true,
                    [10080301u] = true,
                    [10090301u] = true,
                    [10130301u] = true,
                    [10150301u] = true,
                    [10170301u] = true,
                    [10210301u] = true,
                    [10220301u] = true,
                    [10230301u] = true,
                    [10240301u] = true,
                    [10250301u] = true,
                    [10260301u] = true,
                    [10270301u] = true,
                    [10280301u] = true,
                    [10290301u] = true,
                    [10320301u] = true,
                    [10330301u] = true,
                    [10340301u] = true,
                    [10350301u] = true,
                    [10360301u] = true,
                    [10370301u] = true,
                    [10380301u] = true,
                    [10390301u] = true,
                    [10400301u] = true,
                    [10410301u] = true,
                    [10420301u] = true,
                    [10430301u] = true,
                    [10440301u] = true,
                    [10450301u] = true,
                    [10470301u] = true,
                    [10480301u] = true,
                    [10490301u] = true,
                    [10500301u] = true,
                    [10510301u] = true,
                    [10520301u] = true,
                    [10530301u] = true,
                    [10540301u] = true,
                    [10550301u] = true,
                    [10560301u] = true,
                    [10570301u] = true,
                    [10580301u] = true,
                    [10590301u] = true,
                    [10600301u] = true,
                    [10610301u] = true,
                    [10620301u] = true,
                    [10630301u] = true,
                    [10640301u] = true,
                    [10650301u] = true,
                    [10660301u] = true,
                    [10670301u] = true,
                    [10680301u] = true,
                    [10690301u] = true,
                    [10700301u] = true,
                    [10710301u] = true,
                    [10720301u] = true,
                    [10730301u] = true,
                    [10740301u] = true,
                    [10750301u] = true,
                    [10760301u] = true,
                    [10770301u] = true,
                    [10780301u] = true,
                },
                NKDBHMMPFOO = { },
            });
        }
    }
}
