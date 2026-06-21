using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class GameNoticeListDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("first")]
            public int First { get; set; }

            [JsonPropertyName("first_type")]
            public int FirstType { get; set; }

            [JsonPropertyName("list")]
            public List<NoticeItemDto> List { get; set; } = [];

            [JsonPropertyName("total")]
            public int Total { get; set; }

            [JsonPropertyName("version")]
            public int Version { get; set; }
        }

        public class NoticeItemDto
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("type")]
            public int Type { get; set; }

            [JsonPropertyName("picurl_v2")]
            public string PicurlV2 { get; set; } = string.Empty;

            [JsonPropertyName("visible_regions")]
            public string VisibleRegions { get; set; } = string.Empty;

            [JsonPropertyName("visible_sub_ids")]
            public string VisibleSubIds { get; set; } = string.Empty;
        }
    }
}
