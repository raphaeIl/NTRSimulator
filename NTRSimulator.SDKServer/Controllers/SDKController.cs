using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/")]
    public class SDKController : ControllerBase
    {
        [HttpGet("{*catchAll}")]
        public IResult CatchAllGet(string catchAll)
        {
            Log.Information($"HttpGet: {catchAll}");
            return Results.Empty;
        }

        [HttpPost("{*catchAll}")]
        public IResult CatchAllPost(string catchAll)
        {
            Log.Information($"HttpPost: {catchAll}");
            return Results.Empty;
        }
    }
}

