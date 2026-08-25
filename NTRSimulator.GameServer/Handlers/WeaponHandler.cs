using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class WeaponHandler : WeaponHandlerBase
    {
        public override void HandleUnlockAllWeaponAndModSkin(CS_UnlockAllWeaponAndModSkin request, Connection connection)
        {
            SC_UnlockAllWeaponAndModSkin response = new SC_UnlockAllWeaponAndModSkin();
            response.LPCGGDAMJNK.AddRange(request.LPCGGDAMJNK);
            response.PDNBPIJGLJJ.AddRange(request.PDNBPIJGLJJ);
            connection.Send(response);
        }
    }
}
