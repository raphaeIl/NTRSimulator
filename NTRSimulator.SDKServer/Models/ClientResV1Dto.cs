using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class ClientResV1Dto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public ClientResV1DataDto Data { get; set; } = new();

        public class ClientResV1DataDto
        {
            [JsonPropertyName("AuditResVersion")]
            public string AuditResVersion { get; set; } = string.Empty;

            [JsonPropertyName("ResVersion")]
            public string ResVersion { get; set; } = string.Empty;

            [JsonPropertyName("ResUrlCdn")]
            public string ResUrlCdn { get; set; } = string.Empty;

            [JsonPropertyName("ResUrlOss")]
            public string ResUrlOss { get; set; } = string.Empty;

            [JsonPropertyName("AppUpdateUrl")]
            public string AppUpdateUrl { get; set; } = string.Empty;

            [JsonPropertyName("StcVersion")]
            public string StcVersion { get; set; } = string.Empty;

            [JsonPropertyName("ModifyHotfix")]
            public bool ModifyHotfix { get; set; }

            [JsonPropertyName("AppVersionCompatible")]
            public List<string> AppVersionCompatible { get; set; } = [];

            [JsonPropertyName("IsAudit")]
            public bool IsAudit { get; set; }

            [JsonPropertyName("BinaryVersion")]
            public string BinaryVersion { get; set; } = string.Empty;

            [JsonPropertyName("MustUpdateVersionClient")]
            public string MustUpdateVersionClient { get; set; } = string.Empty;

            [JsonPropertyName("MustUpdateVersionBin")]
            public string MustUpdateVersionBin { get; set; } = string.Empty;

            [JsonPropertyName("MustUpdateVersionStc")]
            public string MustUpdateVersionStc { get; set; } = string.Empty;

            [JsonPropertyName("IsCloseBattle")]
            public int IsCloseBattle { get; set; }
        }
    }
}
