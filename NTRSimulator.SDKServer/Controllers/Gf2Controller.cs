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
                Notice(1045, 3),
                Notice(1044, 3),
                Notice(1043, 3),
                Notice(1042, 3),
                Notice(1041, 3),
                Notice(1040, 3),
                Notice(1039, 2),
                Notice(1038, 2),
                Notice(1037, 2),
                Notice(1036, 2),
                Notice(1035, 2),
                Notice(1029, 2),
                Notice(1027, 3),
                Notice(1010, 2),
                Notice(995, 3),
                Notice(961, 3),
                Notice(953, 2),
                Notice(689, 2),
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
                    First = 1045,
                    FirstType = 3,
                    List = list,
                    Total = 21,
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
