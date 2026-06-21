using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class BannerDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public List<BannerItemDto> Data { get; set; } = [];

        public class BannerItemDto
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("channel_id")]
            public int ChannelId { get; set; }

            [JsonPropertyName("pic_name")]
            public string PicName { get; set; } = string.Empty;

            [JsonPropertyName("pic_url")]
            public string PicUrl { get; set; } = string.Empty;

            [JsonPropertyName("type_id")]
            public int TypeId { get; set; }

            [JsonPropertyName("extra_id")]
            public int ExtraId { get; set; }

            [JsonPropertyName("extra")]
            public string Extra { get; set; } = string.Empty;

            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            [JsonPropertyName("end_time")]
            public string EndTime { get; set; } = string.Empty;

            [JsonPropertyName("start_time_ts")]
            public long StartTimeTs { get; set; }

            [JsonPropertyName("end_time_ts")]
            public long EndTimeTs { get; set; }

            [JsonPropertyName("delay")]
            public int Delay { get; set; }

            [JsonPropertyName("is_time_limit")]
            public bool IsTimeLimit { get; set; }

            [JsonPropertyName("sort")]
            public int Sort { get; set; }

            [JsonPropertyName("jump_id")]
            public int JumpId { get; set; }

            [JsonPropertyName("jump_arg")]
            public int JumpArg { get; set; }

            [JsonPropertyName("time_display_type")]
            public int TimeDisplayType { get; set; }

            [JsonPropertyName("event_start_time_ts")]
            public long EventStartTimeTs { get; set; }

            [JsonPropertyName("event_end_time_ts")]
            public long EventEndTimeTs { get; set; }

            [JsonPropertyName("sys_id")]
            public int SysId { get; set; }

            [JsonPropertyName("conditions")]
            public List<object> Conditions { get; set; } = [];

            [JsonPropertyName("visible_regions")]
            public string VisibleRegions { get; set; } = string.Empty;

            [JsonPropertyName("visible_sub_ids")]
            public string VisibleSubIds { get; set; } = string.Empty;
        }
    }
}
