using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class LoginComponentLogDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("list")]
            public List<LogItemDto> List { get; set; } = [];
        }

        public class LogItemDto
        {
            [JsonPropertyName("nexon_plug_version")]
            public string NexonPlugVersion { get; set; } = string.Empty;

            [JsonPropertyName("update_log")]
            public string UpdateLog { get; set; } = string.Empty;

            [JsonPropertyName("create_time")]
            public long CreateTime { get; set; }
        }
    }
}
