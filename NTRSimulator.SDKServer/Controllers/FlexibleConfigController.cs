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
                    PicUrl = "https://gf2-cn.cdn.sunborngame.com/website/platform/F38D5B7EEC37F071D6FE42A2FF8D35F3.png",
                    JumpUrl = string.Empty,
                },
                NexonPlugAddr = "https://gf2-cn.cdn.sunborngame.com/game_resources/package/PCLauncher/",
                NexonPlugVersion = "1.0.7",
                PicName = "F38D5B7EEC37F071D6FE42A2FF8D35F3.png",
                UpdateLog = "<p>修复了一些已知问题。</p>",
                ResourceUpdateSwitch = true,
                CompatibleVersion = string.Empty,
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
                    IsNeedUpdate = false,
                },
            };
        }
    }
}
