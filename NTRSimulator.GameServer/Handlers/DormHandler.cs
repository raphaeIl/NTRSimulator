using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class DormHandler : DormHandlerBase
    {
        public override void HandleDormInfo(CS_DormInfo request, Connection connection)
        {
                    connection.Send(new SC_DormInfo
                    {
                        Info = new NOMHELOJFLJ
                        {
                            PIOFFPPPEPK = { },
                            KBCJNGDOGKJ = 0,
                        },
                        GDJOKNOBNBM = { },
                    });
        }

        public override void HandleGetDormFormationInfo(CS_GetDormFormationInfo request, Connection connection)
        {
            connection.Send(new SC_GetDormFormationInfo
            {
                AHFNBKINDGB = { },
            });
        }

        public override void HandleEnterDorm(CS_EnterDorm request, Connection connection)
        {
            connection.Send(new SC_EnterDorm
            {
                GunId = request.GunId,
            });
        }

        public override void HandleDormSkinChange(CS_DormSkinChange request, Connection connection)
        {
            connection.Send(new SC_DormSkinChange()
            {
                GunId = request.GunId,
                CostumeId = request.CostumeId
            });
        }

    }
}
