using Microsoft.AspNetCore.Mvc;
using NTRSimulator.Common.Utils;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/config")]
    public class ConfigController : ControllerBase
    {
        [HttpPost]
        public IResult PostConfig()
        {
            return Results.Json(CreateConfig());
        }

        [HttpPost("collect_res")]
        public IResult PostCollectRes()
        {
            return Results.Json(CreateConfig());
        }

        private static Models.ConfigDto CreateConfig()
        {
            return new Models.ConfigDto
            {
                Code = 0,
                Msg = "OK",
                Data = new Models.ConfigDto.DataDto
                {
                    GameControl = new Models.ConfigDto.GameControlDto
                    {
                        IsAudit = 0,
                        GateList = $"https://gf2-zoneinfo.sunborngame.com/zone/gatelist?version={StaticConfig.ClientVersion}&type_id=3&game_channel_id=5",
                        ClientResV1 = $"https://gf2-zoneinfo.sunborngame.com/zone/client_res_v1?type_id=3&version={StaticConfig.ClientVersion}&game_channel_id=5",
                    },
                    GameResource = new Models.ConfigDto.GameResourceDto
                    {
                        BannerUrl = "https://gf2-zoneinfo.sunborngame.com/banner",
                        BbsWebUrl = "https://gf2-bbs.exiliumgf.com/release",
                        FlexibleConfigUrl = "https://gf2-zoneinfo.sunborngame.com/flexible_config",
                        GachaRecordUrl = "https://gf2-gacha-record.sunborngame.com/list",
                        GameWeatherApi = "https://gf2-gameweather-api.sunborngame.com/weather",
                        H5LevasitupApiUrl = "https://gf2-h5levasitup-api.sunborngame.com/client/remain_cnt",
                        H5LevasitupWebUrl = "https://gf2.sunborngame.com/lydrlyd/",
                        LotteryH5WebUrl = "https://gf2.sunborngame.com/HHZZRaffle/",
                        NoticeAddr = "https://gf2-zoneinfo.sunborngame.com/gf2/game_notice_list",
                        NoticeHtmlAddr = string.Empty,
                        NoticeWebUrl = "https://gf2-gamenotice.sunborngame.com",
                        PosterAddr = "https://gf2-zoneinfo.sunborngame.com/gf2/poster",
                        RaffleApiUrl = "https://gf2-h52ndanngacha-api.sunborngame.com",
                        RaffleWebUrl = "https://gf2.sunborngame.com/yearendharvest",
                        ReflowApiUrl = "https://gf2-h5back-api.sunborngame.com/game_get_info",
                        ReflowWebUrl = "https://gf2.sunborngame.com/hgbsjlr/cn/",
                        ReportDataUrl = "https://gf2-report-data.sunborngame.com/upload_file",
                        ReviewWebUrl = "https://gf2.sunborngame.com/amhfyj/",
                        SkinBargainWebUrl = "https://gf2.sunborngame.com/npzdjq/",
                        WorldRankUrl = "https://gf2-gameworldrank-api.sunborngame.com/activity/rank",
                        WxgRetentionWebUrl = "https://gf2.sunborngame.com/zfxzs/",
                    },
                    InitParam = new Models.ConfigDto.InitParamDto
                    {
                        AdvertisementReportUrl = "https://ad.com",
                        CustomerServiceUrl = "https://gf2-css.sunborngame.com",
                        FcmUrl = "https://gf2-cn-fcm.sunborngame.com",
                        GameName = "少女前线2：追放",
                        LoginUrl = "https://gf2-zoneinfo.sunborngame.com",
                        OssUrl = "https://gf2.oss-cn-beijing.aliyuncs.com",
                        PayUrl = "https://gf2-zonepay.sunborngame.com",
                        RegisterUrl = "https://gf2-cn-plateuser.sunborngame.com",
                    },
                    OriginConfig =
                    [
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "real_switch",
                            V = "1",
                            UpdateTime = 1634124083,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "pay_qq",
                            V = "若支付遇到问题，指挥官可联系工作人员QQ：2885857717。",
                            UpdateTime = 1715676588,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "anti_addiction_switch",
                            V = "1",
                            UpdateTime = 1634125987,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "graphic_verify_html_url",
                            V = "https://gf2-cn.cdn.sunborngame.com/website/sdk_slide/index.html",
                            UpdateTime = 0,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "agreement_version",
                            V = "0",
                            UpdateTime = 0,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "third_party_info_share_list",
                            V = "https://gf2-cn.cdn.sunborngame.com/website/user_agreement/qa_third_party_info_share_list.html",
                            UpdateTime = 0,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "personal_info_collection_list",
                            V = "https://gf2-cn.cdn.sunborngame.com/website/user_agreement/qa_personal_info_collection_list.html",
                            UpdateTime = 0,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "children_privacy",
                            V = "https://gf2-cn.cdn.sunborngame.com/website/user_agreement/userChildCon.html",
                            UpdateTime = 0,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "notice",
                            V = string.Empty,
                            UpdateTime = 0,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "delete_protocol",
                            V = "https://plateuser.sunborngame.com/agreement/delete_protocol",
                            UpdateTime = 0,
                        },
                        new Models.ConfigDto.ConfigDataDto
                        {
                            K = "delete_notice",
                            V = "<p class=MsoNormal><span lang=EN-US>1.</span><span style='font-family:宋体'>请在安全和常用的网络、设备环境下操作。</span></p><p class=MsoNormal><span lang=EN-US>2.</span><span style='font-family:宋体'>如果账号下有未使用的虚拟货币或付费服务，注销成功后将随账号一同被清空，且您在散爆网络下的所有游戏账号信息均会注销，请谨慎操作。</span></p><p class=MsoNormal><span lang=EN-US>3.</span><span style='font-family:宋体'>请您仔细阅读《<b>注销协议</b>》，注销完成后账号将无法恢复，请谨慎选择并操作。</span></p>",
                            UpdateTime = 0,
                        },
                    ],
                    TraceId = CreateTraceId(),
                },
            };
        }

        private static string CreateTraceId()
        {
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Span<char> suffix = stackalloc char[6];
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < suffix.Length; i++)
            {
                suffix[i] = chars[Random.Shared.Next(chars.Length)];
            }

            return $"{timestamp}_{new string(suffix)}";
        }
    }
}
