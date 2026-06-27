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
            Active = true,
            TotalMails =
            {
                        new Mail
                        {
                            Id = 10264,
                            Type = (MailType)1,
                            MailTempId = 3005,
                            Title = "",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = false,
                            Attached = false,
                            ReceiveTime = 1779500060L,
                            ExpireTime = 1782092060L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 1,
                            BAFMGKOFPDJ = 0,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
            },
            DMLHKOACPIC =
            {
                        new Mail
                        {
                            Id = 10267,
                            Type = (MailType)2,
                            MailTempId = 1623,
                            Title = "5月19日停机维护补偿",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = false,
                            Attached = false,
                            ReceiveTime = 1779152400L,
                            ExpireTime = 1779724799L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 2,
                            BAFMGKOFPDJ = 1623,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
                        new Mail
                        {
                            Id = 10043,
                            Type = (MailType)2,
                            MailTempId = 331,
                            Title = "甜蜜的小礼物",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = true,
                            Attached = true,
                            ReceiveTime = 1722913200L,
                            ExpireTime = 2038446000L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 1,
                            BAFMGKOFPDJ = 331,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
                        new Mail
                        {
                            Id = 10250,
                            Type = (MailType)2,
                            MailTempId = 1413,
                            Title = "【年终奖兑换成功】您的衣装自选凭证已送达",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = true,
                            Attached = true,
                            ReceiveTime = 1769140800L,
                            ExpireTime = 1798732799L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 1,
                            BAFMGKOFPDJ = 1413,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
                        new Mail
                        {
                            Id = 10233,
                            Type = (MailType)2,
                            MailTempId = 1161,
                            Title = "全新功能【定向演化】现已开放",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = true,
                            Attached = true,
                            ReceiveTime = 1759190400L,
                            ExpireTime = 1790726400L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 3,
                            BAFMGKOFPDJ = 1161,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
                        new Mail
                        {
                            Id = 10265,
                            Type = (MailType)2,
                            MailTempId = 1611,
                            Title = "好心的指挥官，帮帮忙吧",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = false,
                            Attached = false,
                            ReceiveTime = 1777582800L,
                            ExpireTime = 1780261200L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 3,
                            BAFMGKOFPDJ = 1611,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
                        new Mail
                        {
                            Id = 10266,
                            Type = (MailType)2,
                            MailTempId = 1624,
                            Title = "从日出到烛光晚餐，指挥官都要陪我哦",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = false,
                            Attached = false,
                            ReceiveTime = 1779224400L,
                            ExpireTime = 1781902800L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 3,
                            BAFMGKOFPDJ = 1624,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
                        new Mail
                        {
                            Id = 10137,
                            Type = (MailType)2,
                            MailTempId = 833,
                            Title = "指挥官性别修改功能现已开放",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = true,
                            Attached = true,
                            ReceiveTime = 1746484310L,
                            ExpireTime = 2064153600L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 1,
                            BAFMGKOFPDJ = 833,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
                        new Mail
                        {
                            Id = 10232,
                            Type = (MailType)2,
                            MailTempId = 1160,
                            Title = "【配件拆解】功能迭代补偿",
                            Content = "",
                            HintText = "",
                            ContentArgs =
                            {
                            },
                            AttachmentItems =
                            {
                            },
                            Read = true,
                            Attached = true,
                            ReceiveTime = 1759190400L,
                            ExpireTime = 1790726400L,
                            DeleteTime = 0L,
                            Sender = 0,
                            JOPJNGBLLDB = (DGNEONELCLC)0,
                            HEJAAMLHNHH = 2,
                            BAFMGKOFPDJ = 1160,
                            HCOFMFNBFJC = 0,
                            MJLMPPLNKIN =
                            {
                            },
                            MLPKIGPMAFO =
                            {
                            },
                            LFMFIGICHNE =
                            {
                            },
                            BNMMMNICFMK =
                            {
                            },
                            FCHMDDAOMGI = "",
                            FGKHFCFBHMG =
                            {
                            },
                        },
            },
        });
        }
    }
}
