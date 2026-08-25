using Microsoft.AspNetCore.Mvc;
using NTRSimulator.Common.Utils;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/gf2")]
    public class Gf2Controller : ControllerBase
    {
        [HttpGet("game_notice_list")]
        public IResult GetGameNoticeList(
            [FromQuery(Name = "game_channel_id")] string? gameChannelId,
            [FromQuery(Name = "type_id")] string? typeId,
            [FromQuery] string? t,
            [FromQuery] string? language,
            [FromQuery(Name = "sub_id")] string? subId)
        {
            return Results.Json(CreateGameNoticeList());
        }

        [HttpGet("poster")]
        public IResult GetPoster(
            [FromQuery(Name = "game_channel_id")] string? gameChannelId,
            [FromQuery(Name = "type_id")] string? typeId,
            [FromQuery] string? t)
        {
            PosterDto poster = new()
            {
                Code = 0,
                Msg = "OK",
                Data = new PosterDto.DataDto
                {
                    List = [],
                    Total = 0,
                },
            };

            return Results.Json(poster);
        }

        private static GameNoticeListDto CreateGameNoticeList()
        {
            List<GameNoticeListDto.NoticeItemDto> list =
            [
                Notice(1114, 3),
                Notice(1113, 3),
                Notice(1112, 3),
                Notice(1111, 3),
                Notice(1110, 3),
                Notice(1109, 3),
                Notice(1108, 3),
                Notice(1107, 2),
                Notice(1106, 2),
                Notice(1105, 2),
                Notice(1104, 2),
                Notice(1103, 2),
                Notice(1099, 2),
                Notice(1098, 2),
                Notice(1097, 2),
                Notice(1072, 3),
                Notice(1063, 2),
                Notice(995, 3),
                Notice(953, 2),
                Notice(164, 1),
                Notice(254, 1),
                Notice(165, 1),
            ];

            return new GameNoticeListDto
            {
                Code = 0,
                Msg = "OK",
                Data = new GameNoticeListDto.DataDto
                {
                    First = 1114,
                    FirstType = 3,
                    List = list,
                    Total = 22,
                    Version = StaticConfig.GameNoticeListVersion,
                },
            };
        }

        private static GameNoticeListDto.NoticeItemDto Notice(int id, int type)
        {
            return new GameNoticeListDto.NoticeItemDto
            {
                Id = id,
                Type = type,
            };
        }
    }
}
