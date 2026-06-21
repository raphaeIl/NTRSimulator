using Microsoft.AspNetCore.Mvc;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/api/1/envelope")]
    public class EnvelopeController : ControllerBase
    {
        [HttpPost]
        public IResult PostEnvelope()
        {
            return Results.Json(new Dictionary<string, object>());
        }
    }
}
