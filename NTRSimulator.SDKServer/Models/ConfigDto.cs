using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class ConfigDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("game_control")]
            public GameControlDto GameControl { get; set; } = new();

            [JsonPropertyName("game_resource")]
            public GameResourceDto GameResource { get; set; } = new();

            [JsonPropertyName("init_param")]
            public InitParamDto InitParam { get; set; } = new();

            [JsonPropertyName("origin_config")]
            public List<ConfigDataDto> OriginConfig { get; set; } = [];

            [JsonPropertyName("trace_id")]
            public string TraceId { get; set; } = string.Empty;
        }

        public class GameControlDto
        {
            [JsonPropertyName("is_audit")]
            public int IsAudit { get; set; }

            [JsonPropertyName("gate_list")]
            public string GateList { get; set; } = string.Empty;

            [JsonPropertyName("client_res_v1")]
            public string ClientResV1 { get; set; } = string.Empty;
        }

        public class GameResourceDto
        {
            [JsonPropertyName("banner_url")]
            public string BannerUrl { get; set; } = string.Empty;

            [JsonPropertyName("bbs_web_url")]
            public string BbsWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("flexible_config_url")]
            public string FlexibleConfigUrl { get; set; } = string.Empty;

            [JsonPropertyName("gacha_record_url")]
            public string GachaRecordUrl { get; set; } = string.Empty;

            [JsonPropertyName("game_weather_api")]
            public string GameWeatherApi { get; set; } = string.Empty;

            [JsonPropertyName("h5levasitup_api_url")]
            public string H5LevasitupApiUrl { get; set; } = string.Empty;

            [JsonPropertyName("h5levasitup_web_url")]
            public string H5LevasitupWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("lottery_h5_web_url")]
            public string LotteryH5WebUrl { get; set; } = string.Empty;

            [JsonPropertyName("notice_addr")]
            public string NoticeAddr { get; set; } = string.Empty;

            [JsonPropertyName("notice_html_addr")]
            public string NoticeHtmlAddr { get; set; } = string.Empty;

            [JsonPropertyName("notice_web_url")]
            public string NoticeWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("poster_addr")]
            public string PosterAddr { get; set; } = string.Empty;

            [JsonPropertyName("raffle_api_url")]
            public string RaffleApiUrl { get; set; } = string.Empty;

            [JsonPropertyName("raffle_web_url")]
            public string RaffleWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("reflow_api_url")]
            public string ReflowApiUrl { get; set; } = string.Empty;

            [JsonPropertyName("reflow_web_url")]
            public string ReflowWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("report_data_url")]
            public string ReportDataUrl { get; set; } = string.Empty;

            [JsonPropertyName("review_web_url")]
            public string ReviewWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("skin_bargain_web_url")]
            public string SkinBargainWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("world_rank_url")]
            public string WorldRankUrl { get; set; } = string.Empty;

            [JsonPropertyName("wxg_retention_web_url")]
            public string WxgRetentionWebUrl { get; set; } = string.Empty;
        }

        public class InitParamDto
        {
            [JsonPropertyName("advertisement_report_url")]
            public string AdvertisementReportUrl { get; set; } = string.Empty;

            [JsonPropertyName("customer_service_url")]
            public string CustomerServiceUrl { get; set; } = string.Empty;

            [JsonPropertyName("fcm_url")]
            public string FcmUrl { get; set; } = string.Empty;

            [JsonPropertyName("game_name")]
            public string GameName { get; set; } = string.Empty;

            [JsonPropertyName("login_url")]
            public string LoginUrl { get; set; } = string.Empty;

            [JsonPropertyName("oss_url")]
            public string OssUrl { get; set; } = string.Empty;

            [JsonPropertyName("pay_url")]
            public string PayUrl { get; set; } = string.Empty;

            [JsonPropertyName("register_url")]
            public string RegisterUrl { get; set; } = string.Empty;
        }

        public class ConfigDataDto
        {
            [JsonPropertyName("k")]
            public string K { get; set; } = string.Empty;

            [JsonPropertyName("v")]
            public string V { get; set; } = string.Empty;

            [JsonPropertyName("update_time")]
            public int UpdateTime { get; set; }
        }
    }
}
