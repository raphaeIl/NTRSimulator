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
                    { 1u, new Chapter
                    {
                        Id = 1,
                        Stories = { 101, 102, 103, 104, 105, 183, 106, 184, 141, 107, 142, 108, 109, 143, 110 },
                        Finished = true,
                        Main = 10,
                        MADLPEJIODH =
                        {
                            { 1u, 10 },
                            { 2u, 2 },
                            { 11u, 3 },
                        },
                    } },
                    { 3001u, new Chapter { Id = 3001 } },
                    { 3002u, new Chapter { Id = 3002 } },
                    { 3003u, new Chapter { Id = 3003 } },
                    { 3004u, new Chapter { Id = 3004 } },
                    { 3005u, new Chapter { Id = 3005 } },
                    { 3006u, new Chapter { Id = 3006 } },
                    { 3007u, new Chapter { Id = 3007 } },
                    { 3008u, new Chapter { Id = 3008 } },
                    { 3009u, new Chapter { Id = 3009 } },
                    { 3010u, new Chapter { Id = 3010 } },
                    { 3011u, new Chapter { Id = 3011 } },
                    { 3012u, new Chapter { Id = 3012 } },
                    { 3013u, new Chapter { Id = 3013 } },
                    { 3014u, new Chapter { Id = 3014 } },
                    { 3015u, new Chapter { Id = 3015 } },
                    { 3016u, new Chapter { Id = 3016 } },
                    { 3017u, new Chapter { Id = 3017 } },
                    { 3018u, new Chapter { Id = 3018 } },
                    { 3019u, new Chapter { Id = 3019 } },
                    { 3020u, new Chapter { Id = 3020 } },
                    { 3021u, new Chapter { Id = 3021 } },
                    { 3022u, new Chapter { Id = 3022 } },
                    { 3030u, new Chapter { Id = 3030 } },
                    { 3031u, new Chapter { Id = 3031 } },
                    { 3039u, new Chapter { Id = 3039 } },
                    { 3040u, new Chapter { Id = 3040 } },
                    { 93001u, new Chapter { Id = 93001 } },
                    { 93002u, new Chapter { Id = 93002 } },
                    { 93003u, new Chapter { Id = 93003 } },
                    { 93004u, new Chapter { Id = 93004 } },
                    { 93005u, new Chapter { Id = 93005 } },
                    { 93006u, new Chapter { Id = 93006 } },
                    { 93007u, new Chapter { Id = 93007 } },
                    { 93008u, new Chapter { Id = 93008 } },
                    { 93009u, new Chapter { Id = 93009 } },
                    { 93010u, new Chapter { Id = 93010 } },
                    { 93011u, new Chapter { Id = 93011 } },
                    { 93012u, new Chapter { Id = 93012 } },
                    { 93013u, new Chapter { Id = 93013 } },
                    { 93014u, new Chapter { Id = 93014 } },
                    { 93015u, new Chapter { Id = 93015 } },
                    { 93016u, new Chapter { Id = 93016 } },
                    { 93017u, new Chapter { Id = 93017 } },
                    { 93018u, new Chapter { Id = 93018 } },
                    { 93019u, new Chapter { Id = 93019 } },
                    { 93020u, new Chapter { Id = 93020 } },
                    { 93021u, new Chapter { Id = 93021 } },
                    { 93022u, new Chapter { Id = 93022 } },
                    { 994033u, new Chapter { Id = 994033 } },
                    { 994034u, new Chapter { Id = 994034 } },
                    { 994042u, new Chapter { Id = 994042 } },
                    { 994043u, new Chapter { Id = 994043 } },
                },
            });
        }
    }
}
