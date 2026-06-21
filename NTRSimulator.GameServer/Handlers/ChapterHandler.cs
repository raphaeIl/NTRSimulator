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
                Field1 =
                {
                    { 1u, new SC_Chapters_F1ValueType
                    {
                        Field1 = 1,
                        Field2 = { 101, 102, 103, 104, 105, 183, 106, 184, 141, 107, 142, 108, 109, 143, 110 },
                        Field4 = true,
                        Field5 = 10,
                        Field6 =
                        {
                            { 1u, 10 },
                            { 2u, 2 },
                            { 11u, 3 },
                        },
                    } },
                    { 3001u, new SC_Chapters_F1ValueType { Field1 = 3001 } },
                    { 3002u, new SC_Chapters_F1ValueType { Field1 = 3002 } },
                    { 3003u, new SC_Chapters_F1ValueType { Field1 = 3003 } },
                    { 3004u, new SC_Chapters_F1ValueType { Field1 = 3004 } },
                    { 3005u, new SC_Chapters_F1ValueType { Field1 = 3005 } },
                    { 3006u, new SC_Chapters_F1ValueType { Field1 = 3006 } },
                    { 3007u, new SC_Chapters_F1ValueType { Field1 = 3007 } },
                    { 3008u, new SC_Chapters_F1ValueType { Field1 = 3008 } },
                    { 3009u, new SC_Chapters_F1ValueType { Field1 = 3009 } },
                    { 3010u, new SC_Chapters_F1ValueType { Field1 = 3010 } },
                    { 3011u, new SC_Chapters_F1ValueType { Field1 = 3011 } },
                    { 3012u, new SC_Chapters_F1ValueType { Field1 = 3012 } },
                    { 3013u, new SC_Chapters_F1ValueType { Field1 = 3013 } },
                    { 3014u, new SC_Chapters_F1ValueType { Field1 = 3014 } },
                    { 3015u, new SC_Chapters_F1ValueType { Field1 = 3015 } },
                    { 3016u, new SC_Chapters_F1ValueType { Field1 = 3016 } },
                    { 3017u, new SC_Chapters_F1ValueType { Field1 = 3017 } },
                    { 3018u, new SC_Chapters_F1ValueType { Field1 = 3018 } },
                    { 3019u, new SC_Chapters_F1ValueType { Field1 = 3019 } },
                    { 3020u, new SC_Chapters_F1ValueType { Field1 = 3020 } },
                    { 3021u, new SC_Chapters_F1ValueType { Field1 = 3021 } },
                    { 3022u, new SC_Chapters_F1ValueType { Field1 = 3022 } },
                    { 3030u, new SC_Chapters_F1ValueType { Field1 = 3030 } },
                    { 3031u, new SC_Chapters_F1ValueType { Field1 = 3031 } },
                    { 3039u, new SC_Chapters_F1ValueType { Field1 = 3039 } },
                    { 3040u, new SC_Chapters_F1ValueType { Field1 = 3040 } },
                    { 93001u, new SC_Chapters_F1ValueType { Field1 = 93001 } },
                    { 93002u, new SC_Chapters_F1ValueType { Field1 = 93002 } },
                    { 93003u, new SC_Chapters_F1ValueType { Field1 = 93003 } },
                    { 93004u, new SC_Chapters_F1ValueType { Field1 = 93004 } },
                    { 93005u, new SC_Chapters_F1ValueType { Field1 = 93005 } },
                    { 93006u, new SC_Chapters_F1ValueType { Field1 = 93006 } },
                    { 93007u, new SC_Chapters_F1ValueType { Field1 = 93007 } },
                    { 93008u, new SC_Chapters_F1ValueType { Field1 = 93008 } },
                    { 93009u, new SC_Chapters_F1ValueType { Field1 = 93009 } },
                    { 93010u, new SC_Chapters_F1ValueType { Field1 = 93010 } },
                    { 93011u, new SC_Chapters_F1ValueType { Field1 = 93011 } },
                    { 93012u, new SC_Chapters_F1ValueType { Field1 = 93012 } },
                    { 93013u, new SC_Chapters_F1ValueType { Field1 = 93013 } },
                    { 93014u, new SC_Chapters_F1ValueType { Field1 = 93014 } },
                    { 93015u, new SC_Chapters_F1ValueType { Field1 = 93015 } },
                    { 93016u, new SC_Chapters_F1ValueType { Field1 = 93016 } },
                    { 93017u, new SC_Chapters_F1ValueType { Field1 = 93017 } },
                    { 93018u, new SC_Chapters_F1ValueType { Field1 = 93018 } },
                    { 93019u, new SC_Chapters_F1ValueType { Field1 = 93019 } },
                    { 93020u, new SC_Chapters_F1ValueType { Field1 = 93020 } },
                    { 93021u, new SC_Chapters_F1ValueType { Field1 = 93021 } },
                    { 93022u, new SC_Chapters_F1ValueType { Field1 = 93022 } },
                    { 994033u, new SC_Chapters_F1ValueType { Field1 = 994033 } },
                    { 994034u, new SC_Chapters_F1ValueType { Field1 = 994034 } },
                    { 994042u, new SC_Chapters_F1ValueType { Field1 = 994042 } },
                    { 994043u, new SC_Chapters_F1ValueType { Field1 = 994043 } },
                },
            });
        }
    }
}
