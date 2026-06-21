using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class ClientGameUrlDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("bbs_web_url")]
            public string BbsWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("game_weather_api")]
            public string GameWeatherApi { get; set; } = string.Empty;

            [JsonPropertyName("h5levasitup_api_url")]
            public string H5LevasitupApiUrl { get; set; } = string.Empty;

            [JsonPropertyName("h5levasitup_web_url")]
            public string H5LevasitupWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("lottery_h5_web_url")]
            public string LotteryH5WebUrl { get; set; } = string.Empty;

            [JsonPropertyName("raffle_api_url")]
            public string RaffleApiUrl { get; set; } = string.Empty;

            [JsonPropertyName("raffle_web_url")]
            public string RaffleWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("reflow_api_url")]
            public string ReflowApiUrl { get; set; } = string.Empty;

            [JsonPropertyName("reflow_web_url")]
            public string ReflowWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("review_web_url")]
            public string ReviewWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("skin_bargain_web_url")]
            public string SkinBargainWebUrl { get; set; } = string.Empty;

            [JsonPropertyName("world_rank_url")]
            public string WorldRankUrl { get; set; } = string.Empty;

            [JsonPropertyName("wxg_retention_web_url")]
            public string WxgRetentionWebUrl { get; set; } = string.Empty;
        }
    }
}
