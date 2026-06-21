using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/index")]
    public class IndexController : ControllerBase
    {
        [HttpPost]
        public IResult PostIndex()
        {
            IndexDto response = new()
            {
                Code = 0,
                Msg = string.Empty,
            };

            return Results.Json(response);
        }
    }
}
