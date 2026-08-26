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
                    PIOFFPPPEPK =
                    {
                        [1025] = new IIAPLDFGPNF { OFOAKMGLEPL = 1025, PPMIBJEJABD = 1102501 },
                        [1034] = new IIAPLDFGPNF { OFOAKMGLEPL = 1034, PPMIBJEJABD = 0 },
                        [1039] = new IIAPLDFGPNF { OFOAKMGLEPL = 1039, PPMIBJEJABD = 1103901 },
                        [1042] = new IIAPLDFGPNF { OFOAKMGLEPL = 1042, PPMIBJEJABD = 1104201 },
                        [1045] = new IIAPLDFGPNF { OFOAKMGLEPL = 1045, PPMIBJEJABD = 0 },
                        [1047] = new IIAPLDFGPNF { OFOAKMGLEPL = 1047, PPMIBJEJABD = 1104701 },
                        [1048] = new IIAPLDFGPNF { OFOAKMGLEPL = 1048, PPMIBJEJABD = 1104801 },
                        [1052] = new IIAPLDFGPNF { OFOAKMGLEPL = 1052, PPMIBJEJABD = 1105203 },
                        [1054] = new IIAPLDFGPNF { OFOAKMGLEPL = 1054, PPMIBJEJABD = 1105401 },
                        [1056] = new IIAPLDFGPNF { OFOAKMGLEPL = 1056, PPMIBJEJABD = 1105601 },
                    },
                    KBCJNGDOGKJ = 1032,
                },
                GDJOKNOBNBM =
                {
                    [1103901] = 273,
                    [1104201] = 273,
                    [1104801] = 273,
                    [1105203] = 545,
                    [1105401] = 273,
                },
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
