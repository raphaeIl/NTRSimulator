using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class AccountInfoDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public DataDto Data { get; set; } = new();

        public class DataDto
        {
            [JsonPropertyName("uid")]
            public int Uid { get; set; }

            [JsonPropertyName("account")]
            public string Account { get; set; } = string.Empty;

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

            [JsonPropertyName("id_cards")]
            public string IdCards { get; set; } = string.Empty;

            [JsonPropertyName("id_name")]
            public string IdName { get; set; } = string.Empty;

            [JsonPropertyName("css_token")]
            public string CssToken { get; set; } = string.Empty;

            [JsonPropertyName("is_need_set_passwd")]
            public bool IsNeedSetPasswd { get; set; }

            [JsonPropertyName("uc_account_token")]
            public string UcAccountToken { get; set; } = string.Empty;
        }
    }
}
