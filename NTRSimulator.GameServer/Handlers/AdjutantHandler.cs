using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class AdjutantHandler : AdjutantHandlerBase
    {
        public override void HandleAdjutantInfo(CS_AdjutantInfo request, Connection connection)
        {
            connection.Send(new SC_AdjutantInfo
            {
                Field1 = new SC_AdjutantInfo_F1Type
                {
                    Field1 = 0,
                    Field2 = 0,
                    Field3 = { 10202, 0, 0, 0 },
                    Field4 = new SC_AdjutantInfo_F1Type_F4Type
                    {
                        Field1 = 1001,
                        Field2 = 2001
                    }
                }
            });
        }
    }
}
