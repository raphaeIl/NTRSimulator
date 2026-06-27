using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class GmConfigHandler : GmConfigHandlerBase
    {
        public override void HandleGetGmConfig(CS_GetGmConfig request, Connection connection)
        {
            connection.Send(
            new SC_GetGmConfig
            {
                FHMAIHPMLJD =
                {
                    new FFHEDKJNNCE
                    {
                        GBBABCAJHBL = (Enum_None_CustomText_RatingIos_RatingAndroid_CloseFunctions)1,
                        Field2 = new SC_GetGmConfig_F1Type_F2Type
                        {
                            GBBABCAJHBL =
                            { },
                        },
                        Field3 = null,
                        Field4 = null,
                        Field5 = null,
                        Field6 = null,
                        Field7 = 0,
                    },
                    new FFHEDKJNNCE
                    {
                        GBBABCAJHBL = (Enum_None_CustomText_RatingIos_RatingAndroid_CloseFunctions)4,
                        Field2 = null,
                        Field3 = null,
                        Field4 = null,
                        Field5 = new SC_GetGmConfig_F1Type_F5Type
                        {
                            GBBABCAJHBL = { },
                        },
                        Field6 = null,
                        Field7 = 0,
                    },
                },
            }
            );
        }
    }
}
