using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class DishBagHandler : DishBagHandlerBase
    {
        public override void HandleDishBagInfo(CS_DishBagInfo request, Connection connection)
        {
            connection.Send(
            new SC_DishBagInfo
            {
                Info = new SC_DarkZonePlayerUpdate_F2Type_F48Type
                {
                    Info = { },
                },
            }
            );
        }
    }
}
