using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class PosterDto
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
            public List<object> List { get; set; } = [];

            [JsonPropertyName("total")]
            public int Total { get; set; }
        }
    }
}
