using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class MailHandler : MailHandlerBase
    {
        public override void HandleMails(CS_Mails request, Connection connection)
        {
            connection.Send(2,
        new SC_Mails
        {
            Field1 = true,
            Field2 =
            {
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10264,
                            Field2 = (Enum_None_System_SystemGroup_Gm)1,
                            Field3 = 3005,
                            Field4 = "",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = false,
                            Field10 = false,
                            Field11 = 1779500060L,
                            Field12 = 1782092060L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 1,
                            Field17 = 0,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
            },
            Field3 =
            {
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10267,
                            Field2 = (Enum_None_System_SystemGroup_Gm)2,
                            Field3 = 1623,
                            Field4 = "5月19日停机维护补偿",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = false,
                            Field10 = false,
                            Field11 = 1779152400L,
                            Field12 = 1779724799L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 2,
                            Field17 = 1623,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10043,
                            Field2 = (Enum_None_System_SystemGroup_Gm)2,
                            Field3 = 331,
                            Field4 = "甜蜜的小礼物",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = true,
                            Field10 = true,
                            Field11 = 1722913200L,
                            Field12 = 2038446000L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 1,
                            Field17 = 331,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10250,
                            Field2 = (Enum_None_System_SystemGroup_Gm)2,
                            Field3 = 1413,
                            Field4 = "【年终奖兑换成功】您的衣装自选凭证已送达",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = true,
                            Field10 = true,
                            Field11 = 1769140800L,
                            Field12 = 1798732799L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 1,
                            Field17 = 1413,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10233,
                            Field2 = (Enum_None_System_SystemGroup_Gm)2,
                            Field3 = 1161,
                            Field4 = "全新功能【定向演化】现已开放",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = true,
                            Field10 = true,
                            Field11 = 1759190400L,
                            Field12 = 1790726400L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 3,
                            Field17 = 1161,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10265,
                            Field2 = (Enum_None_System_SystemGroup_Gm)2,
                            Field3 = 1611,
                            Field4 = "好心的指挥官，帮帮忙吧",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = false,
                            Field10 = false,
                            Field11 = 1777582800L,
                            Field12 = 1780261200L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 3,
                            Field17 = 1611,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10266,
                            Field2 = (Enum_None_System_SystemGroup_Gm)2,
                            Field3 = 1624,
                            Field4 = "从日出到烛光晚餐，指挥官都要陪我哦",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = false,
                            Field10 = false,
                            Field11 = 1779224400L,
                            Field12 = 1781902800L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 3,
                            Field17 = 1624,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10137,
                            Field2 = (Enum_None_System_SystemGroup_Gm)2,
                            Field3 = 833,
                            Field4 = "指挥官性别修改功能现已开放",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = true,
                            Field10 = true,
                            Field11 = 1746484310L,
                            Field12 = 2064153600L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 1,
                            Field17 = 833,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
                        new SC_MailAdd_F1Type
                        {
                            Field1 = 10232,
                            Field2 = (Enum_None_System_SystemGroup_Gm)2,
                            Field3 = 1160,
                            Field4 = "【配件拆解】功能迭代补偿",
                            Field5 = "",
                            Field6 = "",
                            Field7 =
                            {
                            },
                            Field8 =
                            {
                            },
                            Field9 = true,
                            Field10 = true,
                            Field11 = 1759190400L,
                            Field12 = 1790726400L,
                            Field13 = 0L,
                            Field14 = 0,
                            Field15 = (Enum_None_Join_Survey)0,
                            Field16 = 2,
                            Field17 = 1160,
                            Field18 = 0,
                            Field19 =
                            {
                            },
                            Field20 =
                            {
                            },
                            Field21 =
                            {
                            },
                            Field22 =
                            {
                            },
                            Field23 = "",
                            Field24 =
                            {
                            },
                        },
            },
        });
        }
    }
}
