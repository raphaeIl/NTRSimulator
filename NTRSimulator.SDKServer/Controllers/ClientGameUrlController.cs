using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/client_game_url")]
    public class ClientGameUrlController : ControllerBase
    {
        [HttpGet]
        public IResult GetClientGameUrl()
        {
            ClientGameUrlDto response = new()
            {
                Code = 0,
                Msg = "OK",
                Data = new ClientGameUrlDto.DataDto
                {
                    BbsWebUrl = "https://gf2-bbs.exiliumgf.com/release",
                    GameWeatherApi = "https://gf2-gameweather-api.sunborngame.com/weather",
                    H5LevasitupApiUrl = "https://gf2-h5levasitup-api.sunborngame.com/client/remain_cnt",
                    H5LevasitupWebUrl = "https://gf2.sunborngame.com/lydrlyd/",
                    LotteryH5WebUrl = "https://gf2.sunborngame.com/HHZZRaffle/",
                    RaffleApiUrl = "https://gf2-h52ndanngacha-api.sunborngame.com",
                    RaffleWebUrl = "https://gf2.sunborngame.com/yearendharvest",
                    ReflowApiUrl = "https://gf2-h5back-api.sunborngame.com/game_get_info",
                    ReflowWebUrl = "https://gf2.sunborngame.com/hgbsjlr/cn/",
                    ReviewWebUrl = "https://gf2.sunborngame.com/amhfyj/",
                    SkinBargainWebUrl = "https://gf2.sunborngame.com/npzdjq/",
                    WorldRankUrl = "https://gf2-gameworldrank-api.sunborngame.com/activity/rank",
                    WxgRetentionWebUrl = "https://gf2.sunborngame.com/zfxzs/",
                },
            };

            return Results.Json(response);
        }
    }
}
