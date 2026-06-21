using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class WeaponHandler : WeaponHandlerBase
    {
        public override void HandleUnlockAllWeaponAndModSkin(CS_UnlockAllWeaponAndModSkin request, Connection connection)
        {
            SC_UnlockAllWeaponAndModSkin response = new SC_UnlockAllWeaponAndModSkin();
            response.Field1.AddRange(request.Field1);
            response.Field2.AddRange(request.Field2);
            connection.Send(response);
        }
    }
}
