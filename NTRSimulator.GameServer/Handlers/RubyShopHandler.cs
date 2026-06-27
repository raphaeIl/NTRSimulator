using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class RubyShopHandler : RubyShopHandlerBase
    {
        public override void HandleGetRubyShopInfo(CS_GetRubyShopInfo request, Connection connection)
        {
                    connection.Send(new SC_GetRubyShopInfo
                    {
                        CIMEBELLALJ = { },
                    });
        }

    }
}
