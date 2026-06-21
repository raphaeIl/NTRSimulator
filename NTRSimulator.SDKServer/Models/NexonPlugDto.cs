using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class NexonPlugDto
    {
        [JsonPropertyName("ab_resource_addr")]
        public string AbResourceAddr { get; set; } = string.Empty;

        [JsonPropertyName("ab_resource_version")]
        public string AbResourceVersion { get; set; } = string.Empty;

        [JsonPropertyName("game_client_version")]
        public string GameClientVersion { get; set; } = string.Empty;

        [JsonPropertyName("game_download_addr")]
        public string GameDownloadAddr { get; set; } = string.Empty;

        [JsonPropertyName("head_pic")]
        public HeadPicDto HeadPic { get; set; } = new();

        [JsonPropertyName("nexon_plug_addr")]
        public string NexonPlugAddr { get; set; } = string.Empty;

        [JsonPropertyName("nexon_plug_version")]
        public string NexonPlugVersion { get; set; } = string.Empty;

        [JsonPropertyName("pic_name")]
        public string PicName { get; set; } = string.Empty;

        [JsonPropertyName("update_log")]
        public string UpdateLog { get; set; } = string.Empty;

        [JsonPropertyName("resource_update_switch")]
        public bool ResourceUpdateSwitch { get; set; }

        [JsonPropertyName("compatible_version")]
        public string CompatibleVersion { get; set; } = string.Empty;

        public class HeadPicDto
        {
            [JsonPropertyName("pic_url")]
            public string PicUrl { get; set; } = string.Empty;

            [JsonPropertyName("jump_url")]
            public string JumpUrl { get; set; } = string.Empty;
        }
    }
}
