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
                        Field1 = new SC_GetCustomFormation_F1Type(),
                    };
                    for (int i = 0; i < 12; i++)
                    {
                        CS_CustomFormationModify_F2Type group = new CS_CustomFormationModify_F2Type
                        {
                            Field1 = "",
                            Field3 = 0,
                        };
                        for (int j = 0; j < 6; j++)
                        {
                            group.Field2.Add(new CS_CustomFormationModify_F2Type_F2Type
                            {
                                Field1 = 0,
                                Field2 = 0,
                            });
                        }
                        response.Field1.Field1.Add(group);
                    }
                    connection.Send(response);
        }

    }
}
