using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class AutoLoginDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("access_token")]
            public string AccessToken { get; set; } = string.Empty;

            [JsonPropertyName("is_real")]
            public int IsReal { get; set; }

            [JsonPropertyName("is_guest")]
            public int IsGuest { get; set; }

            [JsonPropertyName("is_activation")]
            public int IsActivation { get; set; }

            [JsonPropertyName("is_adult")]
            public int IsAdult { get; set; }

            [JsonPropertyName("unfreeze_time")]
            public int UnfreezeTime { get; set; }

            [JsonPropertyName("age")]
            public int Age { get; set; }

            [JsonPropertyName("pi")]
            public string Pi { get; set; } = string.Empty;

            [JsonPropertyName("is_need_set_passwd")]
            public bool IsNeedSetPasswd { get; set; }

            [JsonPropertyName("uc_account_token")]
            public string UcAccountToken { get; set; } = string.Empty;

            [JsonPropertyName("uid")]
            public int Uid { get; set; }
        }
    }
}
