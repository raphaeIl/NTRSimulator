using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class CustomFormationHandler : CustomFormationHandlerBase
    {
        public override void HandleGetCustomFormation(CS_GetCustomFormation request, Connection connection)
        {
                    SC_GetCustomFormation response = new SC_GetCustomFormation
                    {
                        OGNHICHKFAD = new PBEBLABCGEP(),
                    };
                    for (int i = 0; i < 12; i++)
                    {
                        CLHJOEOIFHP group = new CLHJOEOIFHP
                        {
                            Name = "",
                            DCKBFGJJMFG = 0,
                        };
                        for (int j = 0; j < 6; j++)
                        {
                            group.Guns.Add(new NODNJAHDJGD
                            {
                                GunId = 0,
                                WeaponId = 0,
                            });
                        }
                        response.OGNHICHKFAD.KMPIHKFBAEP.Add(group);
                    }
                    connection.Send(response);
        }

    }
}
