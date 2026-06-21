using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/banner")]
    public class BannerController : ControllerBase
    {
        private const string DefaultStartTime = "2026-06-09 08:00:00";
        private const string DefaultEndTime = "2026-06-30 05:59:59";
        private const long DefaultStartTimeTs = 1780963200;
        private const long DefaultEndTimeTs = 1782770399;

        [HttpGet]
        public IResult GetBanner(
            [FromQuery(Name = "game_channel_id")] string? gameChannelId,
            [FromQuery(Name = "type_id")] string? typeId,
            [FromQuery] string? t,
            [FromQuery] string? language,
            [FromQuery(Name = "sub_id")] string? subId)
        {
            return Results.Json(CreateBannerList());
        }

        private static BannerDto CreateBannerList()
        {
            return new BannerDto
            {
                Code = 0,
                Msg = "OK",
                Data =
                [
                    Banner(
                        id: 521,
                        picName: "1780558704139.png",
                        sort: 521,
                        jumpId: 6348),
                    Banner(
                        id: 519,
                        picName: "1780558494111.png",
                        sort: 519,
                        jumpId: 5105),
                    Banner(
                        id: 518,
                        picName: "1780558269360.png",
                        sort: 518,
                        jumpId: 5105),
                    Banner(
                        id: 517,
                        picName: "1780558188669.png",
                        sort: 517,
                        jumpId: 51006),
                    Banner(
                        id: 514,
                        picName: "1780022833928.png",
                        sort: 516,
                        jumpId: 5105,
                        startTime: "2026-06-01 05:00:00",
                        endTime: "2026-06-30 23:59:59",
                        startTimeTs: 1780261200,
                        endTimeTs: 1782835199),
                ],
            };
        }

        private static BannerDto.BannerItemDto Banner(
            int id,
            string picName,
            int sort,
            int jumpId,
            string? startTime = null,
            string? endTime = null,
            long? startTimeTs = null,
            long? endTimeTs = null)
        {
            return new BannerDto.BannerItemDto
            {
                Id = id,
                ChannelId = 1000,
                PicName = picName,
                PicUrl = $"https://gf2-cn.cdn.sunborngame.com/website/platform/{picName}",
                TypeId = 2,
                StartTime = startTime ?? DefaultStartTime,
                EndTime = endTime ?? DefaultEndTime,
                StartTimeTs = startTimeTs ?? DefaultStartTimeTs,
                EndTimeTs = endTimeTs ?? DefaultEndTimeTs,
                Delay = 3,
                Sort = sort,
                JumpId = jumpId,
                SysId = 1000,
            };
        }
    }
}
