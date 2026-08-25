using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class SdkLogDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public string Data { get; set; } = string.Empty;
    }
}
