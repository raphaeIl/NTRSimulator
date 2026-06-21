using System.Net;
using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/client_config")]
    public class ClientConfigController : ControllerBase
    {
        [HttpGet]
        public IResult GetClientConfig(
            [FromQuery(Name = "game_channel_id")] string? gameChannelId,
            [FromQuery] string? version,
            [FromQuery(Name = "type_id")] string? typeId)
        {
            ClientConfigDto config = new()
            {
                Code = 0,
                Message = "OK",
                Data = new ClientConfigDto.DataDto
                {
                    ClientIp = GetClientIp(HttpContext),
                    MicaLogserverUrl = "https://gf2-logserver-api.sunborngame.com",
                },
            };

            return Results.Json(config);
        }

        private static string GetClientIp(HttpContext ctx)
        {
            IPAddress? remoteIp = ctx.Connection.RemoteIpAddress;
            if (remoteIp is null)
            {
                return string.Empty;
            }

            if (remoteIp.IsIPv4MappedToIPv6)
            {
                remoteIp = remoteIp.MapToIPv4();
            }

            return remoteIp.ToString();
        }
    }
}
