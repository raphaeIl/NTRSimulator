using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/login_component")]
    public class LoginComponentController : ControllerBase
    {
        [HttpGet("log")]
        public IResult GetLog()
        {
            LoginComponentLogDto response = new()
            {
                Code = 0,
                Msg = "OK",
                Data = new LoginComponentLogDto.DataDto
                {
                    List =
                    [
                        Log("1.0.4", 1703001600),
                        Log("1.0.5", 1703779200),
                        Log("1.0.6", 1721836800),
                        Log("1.0.7", 1788192000),
                    ],
                },
            };

            return Results.Json(response);
        }

        private static LoginComponentLogDto.LogItemDto Log(string version, long createTime)
        {
            return new LoginComponentLogDto.LogItemDto
            {
                NexonPlugVersion = version,
                UpdateLog = "<p>修复了一些已知问题。</p>",
                CreateTime = createTime,
            };
        }
    }
}
