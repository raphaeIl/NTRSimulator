using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;

namespace NTRSimulator.SDKServer.Models
{
    public class LoginFailureDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        public static IResult Result(int code, string msg) =>
            Results.Json(new LoginFailureDto { Code = code, Msg = msg });
    }
}
