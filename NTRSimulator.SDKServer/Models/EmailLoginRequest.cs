using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class EmailLoginRequest
    {
        [JsonPropertyName("email")]
        public string Account { get; set; } = string.Empty;

        [JsonPropertyName("passwd")]
        public string Password { get; set; } = string.Empty;
    }
}
