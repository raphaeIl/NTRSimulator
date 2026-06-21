using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class TimerHandler : TimerHandlerBase
    {
        public override void HandleTimers(CS_Timers request, Connection connection)
        {
            connection.Send(new SC_Timers());
        }
    }
}
