using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class FlexibleConfigDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("flexible_config")]
            public FlexibleConfigContentDto FlexibleConfig { get; set; } = new();

            [JsonPropertyName("is_need_update")]
            public bool IsNeedUpdate { get; set; }
        }

        public class FlexibleConfigContentDto
        {
            [JsonPropertyName("nexon_plug")]
            public string NexonPlug { get; set; } = string.Empty;
        }
    }
}
