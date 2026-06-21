using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/problems")]
    public class ProblemsController : ControllerBase
    {
        [HttpGet("get_unread_msg")]
        public IResult GetUnreadMsg()
        {
            IndexDto response = new()
            {
                Code = 4,
                Msg = "记录为空",
            };

            return Results.Json(response);
        }
    }
}
