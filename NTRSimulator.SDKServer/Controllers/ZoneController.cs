using Microsoft.AspNetCore.Mvc;
using NTRSimulator.Common.Utils;
using NTRSimulator.SDKServer.Models;
using Serilog;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/zone")]
    public class ZoneController : ControllerBase
    {
        [HttpGet("gatelist")]
        public IResult GetGatelist()
        {
            GatelistDto gatelist = new()
            {
                Code = 0,
                Msg = "OK",
                Data = [StaticConfig.GameServerAddress],
            };

            return Results.Json(gatelist);
        }

        [HttpGet("client_res_v1")]
        public IResult GetClientResV1(
            [FromQuery(Name = "type_id")] string? typeId,
            [FromQuery] string? version,
            [FromQuery(Name = "game_channel_id")] string? gameChannelId,
            [FromQuery] string? t)
        {
            ClientResV1Dto clientRes = CreateClientResV1();

            return Results.Json(clientRes);
        }

        private static ClientResV1Dto CreateClientResV1()
        {
            return new ClientResV1Dto
            {
                Code = 0,
                Msg = "OK",
                Data = new ClientResV1Dto.ClientResV1DataDto
                {
                    AuditResVersion = StaticConfig.AbResourceVersion,
                    ResVersion = StaticConfig.AbResourceVersion,
                    ResUrlCdn = StaticConfig.ResUrlCdn,
                    ResUrlOss = StaticConfig.ResUrlOss,
                    AppUpdateUrl = "https://gf2.sunborngame.com/",
                    StcVersion = StaticConfig.StcVersion,
                    ModifyHotfix = false,
                    AppVersionCompatible = [string.Empty],
                    IsAudit = false,
                    BinaryVersion = StaticConfig.BinaryVersion,
                    MustUpdateVersionClient = StaticConfig.MustUpdateVersionClient,
                    MustUpdateVersionBin = StaticConfig.MustUpdateVersionBin,
                    MustUpdateVersionStc = StaticConfig.MustUpdateVersionStc,
                    IsCloseBattle = 1,
                    PreDownloadResVersion = 0,
                },
            };
        }
    }
}
