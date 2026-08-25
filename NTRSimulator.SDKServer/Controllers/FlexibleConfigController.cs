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
                    PicUrl = "https://gf2-cn.cdn.sunborngame.com/website/platform/8A8BD8299A06E750FF7F4C5D675BCE1E.png",
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
