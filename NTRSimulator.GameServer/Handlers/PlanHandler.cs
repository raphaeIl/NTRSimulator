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
            switch (req.Field1)
            {
                case 1:
                    connection.Send(new SC_Plan
                    {
                        Field1 = 1,
                        Field2 = 10004,
                        Field3 =
                        {
                            new SC_Plan_F3Type
                            {
                                Field1 = 10004,
                                Field2 = 1,
                                Field3 = 1727038800,
                                Field4 = 4070897999,
                                Field5 = { 4 },
                            },
                        },
                    });
                    break;
                case 2:
                    connection.Send(new SC_Plan
                    {
                        Field1 = 2,
                        Field2 = 20138,
                        Field3 =
                        {
                            new SC_Plan_F3Type
                            {
                                Field1 = 20138,
                                Field2 = 2,
                                Field3 = 1779051600,
                                Field4 = 1779652800,
                                Field5 = { 30034 },
                            },
                        },
                    });
                    break;
                case 3:
                    connection.Send(new SC_Plan
                    {
                        Field1 = 3,
                        Field2 = 30034,
                        Field3 =
                        {
                            new SC_Plan_F3Type
                            {
                                Field1 = 30034,
                                Field2 = 3,
                                Field3 = 1779148800,
                                Field4 = 1780865999,
                                Field5 = { 30034 },
                            },
                        },
                    });
                    break;
                case 12:
                    connection.Send(new SC_Plan
                    {
                        Field1 = 12,
                        Field2 = 0,
                        Field3 = { },
                    });
                    break;
                case 93:
                    connection.Send(new SC_Plan
                    {
                        Field1 = 93,
                        Field2 = 0,
                        Field3 = { },
                    });
                    break;
                default:
                    Log.Warning("Unhandled MsgCsPlan Field1={Field1}", req.Field1);
                    break;
            }
        }
    }
}
