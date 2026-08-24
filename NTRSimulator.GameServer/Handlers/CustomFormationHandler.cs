using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class CustomFormationHandler : CustomFormationHandlerBase
    {
        public override void HandleGetCustomFormation(CS_GetCustomFormation request, Connection connection)
        {
            connection.Send(new SC_GetCustomFormation
            {
                OGNHICHKFAD = new ILLNLCMNCOB(),
            });
        }
    }
}
