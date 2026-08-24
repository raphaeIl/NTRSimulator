using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/sdk_log")]
    public class SdkLogController : ControllerBase
    {
        [HttpPost]
        public IResult PostSdkLog()
        {
            SdkLogDto response = new()
            {
                Code = 0,
                Msg = "OK",
                Data = string.Empty,
            };

            return Results.Json(response);
        }
    }
}
