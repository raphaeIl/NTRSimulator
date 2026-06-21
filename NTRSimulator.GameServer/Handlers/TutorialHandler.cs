using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class TutorialHandler : TutorialHandlerBase
    {
        public override void HandleTutorialFinish(CS_TutorialFinish request, Connection connection)
        {
            
        }

        public override void HandleTutorialInfo(CS_TutorialInfo request, Connection connection)
        {
            connection.Send(2, new SC_TutorialInfo
            {
                Field1 = new SC_TutorialInfo_F1Type
                {
                    Field1 =
                    {
                        { 150301u, true },
                        { 150402u, true },
                        { 170104u, true },
                        { 190104u, true },
                        { 500202u, true },
                    },
                    Field2 =
                    {
                        { 102u, true },
                        { 201u, true },
                        { 202u, true },
                        { 203u, true },
                        { 301u, true },
                        { 302u, true },
                        { 303u, true },
                        { 501u, true },
                        { 502u, true },
                        { 503u, true },
                        { 504u, true },
                        { 505u, true },
                        { 506u, true },
                        { 599u, true },
                        { 901u, true },
                        { 902u, true },
                        { 903u, true },
                        { 1301u, true },
                        { 1501u, true },
                        { 1502u, true },
                        { 1503u, true },
                        { 1504u, true },
                        { 1511u, true },
                        { 1512u, true },
                        { 1513u, true },
                        { 1514u, true },
                        { 1515u, true },
                        { 1516u, true },
                        { 1517u, true },
                        { 1518u, true },
                        { 1519u, true },
                        { 1520u, true },
                        { 1601u, true },
                        { 1602u, true },
                        { 1701u, true },
                        { 1702u, true },
                        { 1703u, true },
                        { 1711u, true },
                        { 1712u, true },
                        { 1713u, true },
                        { 1714u, true },
                        { 1715u, true },
                        { 1716u, true },
                        { 1717u, true },
                        { 1718u, true },
                        { 1719u, true },
                        { 1720u, true },
                        { 1801u, true },
                        { 1802u, true },
                        { 1803u, true },
                        { 1901u, true },
                        { 1902u, true },
                        { 1903u, true },
                        { 1911u, true },
                        { 1912u, true },
                        { 1913u, true },
                        { 1914u, true },
                        { 1915u, true },
                        { 1916u, true },
                        { 1917u, true },
                        { 1918u, true },
                        { 1919u, true },
                        { 1920u, true },
                        { 2001u, true },
                        { 2002u, true },
                        { 5001u, true },
                        { 5002u, true },
                        { 5003u, true },
                        { 5004u, true },
                        { 5101u, true },
                    },
                },
            });
        }
    }
}
