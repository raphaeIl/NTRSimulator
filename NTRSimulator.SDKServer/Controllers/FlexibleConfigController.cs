using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using NTRSimulator.Common.Utils;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/flexible_config")]
    public class FlexibleConfigController : ControllerBase
    {
        [HttpGet]
        [HttpPost]
        public IResult GetFlexibleConfig()
        {
            FlexibleConfigDto config = CreateFlexibleConfig();

            return Results.Json(config);
        }

        private static FlexibleConfigDto CreateFlexibleConfig()
        {
            NexonPlugDto nexonPlug = new()
            {
                AbResourceAddr = "https://gf2-cn.cdn.sunborngame.com/game_resources/",
                AbResourceVersion = StaticConfig.AbResourceVersion,
                GameClientVersion = StaticConfig.GameClientVersion,
                GameDownloadAddr = "https://gf2-cn.cdn.sunborngame.com/game_resources/package/PCClient/",
                HeadPic = new NexonPlugDto.HeadPicDto
                {
                    PicUrl = "https://gf2-cn.cdn.sunborngame.com/website/platform/798D0169C70480879D03B8F0EF39055C.png",
                    JumpUrl = string.Empty,
                },
                NexonPlugAddr = "https://gf2-cn.cdn.sunborngame.com/game_resources/package/PCLauncher/",
                NexonPlugVersion = "1.0.6",
                PicName = "platform",
                UpdateLog = "<p>修复了一些已知问题。</p>",
                ResourceUpdateSwitch = true,
                CompatibleVersion = "1.0.4",
            };

            return new FlexibleConfigDto
            {
                Code = 0,
                Msg = "OK",
                Data = new FlexibleConfigDto.DataDto
                {
                    FlexibleConfig = new FlexibleConfigDto.FlexibleConfigContentDto
                    {
                        NexonPlug = JsonSerializer.Serialize(nexonPlug),
                    },
                    IsNeedUpdate = true,
                },
            };
        }
    }
}
