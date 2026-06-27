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
            switch (req.Type)
            {
                case 1:
                    connection.Send(
            new SC_CyclePlan
            {
                Type = 1,
                FKFEIHHMEBF =
                { },
            }
                    );
                    break;
            }
        }
    }
}
