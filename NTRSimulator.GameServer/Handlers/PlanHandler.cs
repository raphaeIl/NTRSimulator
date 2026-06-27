using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class PlanHandler : PlanHandlerBase
    {
        public override void HandlePlan(CS_Plan req, Connection connection)
        {
            switch (req.Type)
            {
                case 1:
                    connection.Send(new SC_Plan
                    {
                        Type = 1,
                        Id = 10004,
                        Plans =
                        {
                            new Plan
                            {
                                Id = 10004,
                                Type = 1,
                                OpenTime = 1727038800,
                                CloseTime = 4070897999,
                                Args = { 4 },
                            },
                        },
                    });
                    break;
                case 2:
                    connection.Send(new SC_Plan
                    {
                        Type = 2,
                        Id = 20138,
                        Plans =
                        {
                            new Plan
                            {
                                Id = 20138,
                                Type = 2,
                                OpenTime = 1779051600,
                                CloseTime = 1779652800,
                                Args = { 30034 },
                            },
                        },
                    });
                    break;
                case 3:
                    connection.Send(new SC_Plan
                    {
                        Type = 3,
                        Id = 30034,
                        Plans =
                        {
                            new Plan
                            {
                                Id = 30034,
                                Type = 3,
                                OpenTime = 1779148800,
                                CloseTime = 1780865999,
                                Args = { 30034 },
                            },
                        },
                    });
                    break;
                case 12:
                    connection.Send(new SC_Plan
                    {
                        Type = 12,
                        Id = 0,
                        Plans = { },
                    });
                    break;
                case 93:
                    connection.Send(new SC_Plan
                    {
                        Type = 93,
                        Id = 0,
                        Plans = { },
                    });
                    break;
                default:
                    Log.Warning("Unhandled MsgCsPlan Field1={Field1}", req.Type);
                    break;
            }
        }
    }
}
