using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class DormHandler : DormHandlerBase
    {
        public override void HandleDormInfo(CS_DormInfo request, Connection connection)
        {
                    connection.Send(new SC_DormInfo
                    {
                        Field1 = new SC_DormInfo_F1Type
                        {
                            Field3 = { },
                            Field9 = 0,
                        },
                        Field2 = { },
                    });
        }

        public override void HandleGetDormFormationInfo(CS_GetDormFormationInfo request, Connection connection)
        {
            connection.Send(new SC_GetDormFormationInfo
            {
                Field1 = { },
            });
        }

        public override void HandleEnterDorm(CS_EnterDorm request, Connection connection)
        {
            connection.Send(new SC_EnterDorm
            {
                Field1 = request.Field1,
            });
        }

        public override void HandleDormSkinChange(CS_DormSkinChange request, Connection connection)
        {
            connection.Send(new SC_DormSkinChange()
            {
                Field1 = request.Field1,
                Field2 = request.Field2
            });
        }

    }
}
