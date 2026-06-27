using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ChapterHandler : ChapterHandlerBase
    {
        public override void HandleChapters(CS_Chapters request, Connection connection)
        {
            connection.Send(2, new SC_Chapters
            {
                Chapters =
                {
                    { 1u, new PGJPDHCFNLN
                    {
                        Id = 1,
                        MPHJHIEFFEA = { 101, 102, 103, 104, 105, 183, 106, 184, 141, 107, 142, 108, 109, 143, 110 },
                        Finished = true,
                        LKAHJICEGHP = 10,
                        MADLPEJIODH =
                        {
                            { 1u, 10 },
                            { 2u, 2 },
                            { 11u, 3 },
                        },
                    } },
                    { 3001u, new PGJPDHCFNLN { Id = 3001 } },
                    { 3002u, new PGJPDHCFNLN { Id = 3002 } },
                    { 3003u, new PGJPDHCFNLN { Id = 3003 } },
                    { 3004u, new PGJPDHCFNLN { Id = 3004 } },
                    { 3005u, new PGJPDHCFNLN { Id = 3005 } },
                    { 3006u, new PGJPDHCFNLN { Id = 3006 } },
                    { 3007u, new PGJPDHCFNLN { Id = 3007 } },
                    { 3008u, new PGJPDHCFNLN { Id = 3008 } },
                    { 3009u, new PGJPDHCFNLN { Id = 3009 } },
                    { 3010u, new PGJPDHCFNLN { Id = 3010 } },
                    { 3011u, new PGJPDHCFNLN { Id = 3011 } },
                    { 3012u, new PGJPDHCFNLN { Id = 3012 } },
                    { 3013u, new PGJPDHCFNLN { Id = 3013 } },
                    { 3014u, new PGJPDHCFNLN { Id = 3014 } },
                    { 3015u, new PGJPDHCFNLN { Id = 3015 } },
                    { 3016u, new PGJPDHCFNLN { Id = 3016 } },
                    { 3017u, new PGJPDHCFNLN { Id = 3017 } },
                    { 3018u, new PGJPDHCFNLN { Id = 3018 } },
                    { 3019u, new PGJPDHCFNLN { Id = 3019 } },
                    { 3020u, new PGJPDHCFNLN { Id = 3020 } },
                    { 3021u, new PGJPDHCFNLN { Id = 3021 } },
                    { 3022u, new PGJPDHCFNLN { Id = 3022 } },
                    { 3030u, new PGJPDHCFNLN { Id = 3030 } },
                    { 3031u, new PGJPDHCFNLN { Id = 3031 } },
                    { 3039u, new PGJPDHCFNLN { Id = 3039 } },
                    { 3040u, new PGJPDHCFNLN { Id = 3040 } },
                    { 93001u, new PGJPDHCFNLN { Id = 93001 } },
                    { 93002u, new PGJPDHCFNLN { Id = 93002 } },
                    { 93003u, new PGJPDHCFNLN { Id = 93003 } },
                    { 93004u, new PGJPDHCFNLN { Id = 93004 } },
                    { 93005u, new PGJPDHCFNLN { Id = 93005 } },
                    { 93006u, new PGJPDHCFNLN { Id = 93006 } },
                    { 93007u, new PGJPDHCFNLN { Id = 93007 } },
                    { 93008u, new PGJPDHCFNLN { Id = 93008 } },
                    { 93009u, new PGJPDHCFNLN { Id = 93009 } },
                    { 93010u, new PGJPDHCFNLN { Id = 93010 } },
                    { 93011u, new PGJPDHCFNLN { Id = 93011 } },
                    { 93012u, new PGJPDHCFNLN { Id = 93012 } },
                    { 93013u, new PGJPDHCFNLN { Id = 93013 } },
                    { 93014u, new PGJPDHCFNLN { Id = 93014 } },
                    { 93015u, new PGJPDHCFNLN { Id = 93015 } },
                    { 93016u, new PGJPDHCFNLN { Id = 93016 } },
                    { 93017u, new PGJPDHCFNLN { Id = 93017 } },
                    { 93018u, new PGJPDHCFNLN { Id = 93018 } },
                    { 93019u, new PGJPDHCFNLN { Id = 93019 } },
                    { 93020u, new PGJPDHCFNLN { Id = 93020 } },
                    { 93021u, new PGJPDHCFNLN { Id = 93021 } },
                    { 93022u, new PGJPDHCFNLN { Id = 93022 } },
                    { 994033u, new PGJPDHCFNLN { Id = 994033 } },
                    { 994034u, new PGJPDHCFNLN { Id = 994034 } },
                    { 994042u, new PGJPDHCFNLN { Id = 994042 } },
                    { 994043u, new PGJPDHCFNLN { Id = 994043 } },
                },
            });
        }
    }
}
