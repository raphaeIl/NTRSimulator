using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/banner")]
    public class BannerController : ControllerBase
    {
        private const string DefaultStartTime = "2026-08-11 08:30:00";
        private const string DefaultEndTime = "2026-09-01 07:59:59";
        private const long DefaultStartTimeTs = 1786408200;
        private const long DefaultEndTimeTs = 1788220799;

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
                        id: 543,
                        picName: "1786011907866.png",
                        sort: 544,
                        jumpId: 6372),
                    Banner(
                        id: 542,
                        picName: "1786011802695.png",
                        sort: 543,
                        jumpId: 5105),
                    Banner(
                        id: 541,
                        picName: "1786011736541.png",
                        sort: 542,
                        jumpId: 5116,
                        startTime: "2026-08-19 05:00:00",
                        startTimeTs: 1787086800),
                    Banner(
                        id: 540,
                        picName: "1786011644363.png",
                        sort: 541,
                        jumpId: 5117),
                    Banner(
                        id: 539,
                        picName: "1786011539480.png",
                        sort: 540,
                        jumpId: 30000),
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
