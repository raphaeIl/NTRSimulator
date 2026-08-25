using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class SimCafeHandler : SimCafeHandlerBase
    {
        public override void HandleGetSimCafeWarmUpInfo(CS_GetSimCafeWarmUpInfo request, Connection connection)
        {
            

                    switch (request.ThemeId)
                    {
                        case 3601:
                            connection.Send(new SC_GetSimCafeWarmUpInfo
                            {
                                ECOOFMAFCBG = new PIBACHAPBJH
                                {
                                    NCINIEDEDFG = 1,
                                    OKGBJPCOMPA = { },
                                    FNOAGJBJGGG = { },
                                    Score = 0,
                                    BPJMFIBFGKC = 1779500060L,
                                },
                                ThemeId = 3601,
                            });
                            break;
                    }
        }

    }
}
