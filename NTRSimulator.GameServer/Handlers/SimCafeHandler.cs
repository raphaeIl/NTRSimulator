using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SimCafeHandler : SimCafeHandlerBase
    {
        public override void HandleGetSimCafeWarmUpInfo(CS_GetSimCafeWarmUpInfo request, Connection connection)
        {
            

                    switch (request.Field1)
                    {
                        case 3601:
                            connection.Send(new SC_GetSimCafeWarmUpInfo
                            {
                                Field1 = new SC_GetSimCafeWarmUpInfo_F1Type
                                {
                                    Field1 = 1,
                                    Field2 = { },
                                    Field3 = { },
                                    Field4 = 0,
                                    Field5 = 1779500060L,
                                },
                                Field2 = 3601,
                            });
                            break;
                    }
        }

    }
}
