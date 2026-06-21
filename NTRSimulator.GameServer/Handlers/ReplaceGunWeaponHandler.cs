using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ReplaceGunWeaponHandler : ReplaceGunWeaponHandlerBase
    {
        public override void HandleReplaceGunWeaponModSkin(CS_ReplaceGunWeaponModSkin request, Connection connection)
        {
            connection.Send(new SC_ReplaceGunWeaponModSkin
            {
                Field1 = request.Field1,
                Field2 = request.Field2,
                Field3 = request.Field3,
            });
        }
    }
}
