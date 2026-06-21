using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class IndexDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;
    }
}
