using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class ClientConfigDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("client_ip")]
            public string ClientIp { get; set; } = string.Empty;

            [JsonPropertyName("mica_logserver_url")]
            public string MicaLogserverUrl { get; set; } = string.Empty;
        }
    }
}
