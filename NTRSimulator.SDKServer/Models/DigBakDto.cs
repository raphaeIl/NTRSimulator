using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class DigBakDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("data")]
            public string Data { get; set; } = string.Empty;

            [JsonPropertyName("res")]
            public string Res { get; set; } = string.Empty;
        }
    }
}
