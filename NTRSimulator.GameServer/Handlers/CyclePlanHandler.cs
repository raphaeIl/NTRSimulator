using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using PcapDotNet.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class CyclePlanHandler : CyclePlanHandlerBase
    {
        public override void HandleCyclePlan(CS_CyclePlan req, Connection connection)
        {
            switch (req.Field1)
            {
                case 1:
                    connection.Send(
            new SC_CyclePlan
            {
                Field1 = 1,
                Field2 =
                { },
            }
                    );
                    break;
            }
        }
    }
}
