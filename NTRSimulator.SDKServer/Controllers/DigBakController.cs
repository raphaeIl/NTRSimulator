using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;

namespace NTRSimulator.SDKServer.Controllers
{
    [ApiController]
    [Route("/dig_bak")]
    public class DigBakController : ControllerBase
    {
        [HttpPost]
        public IResult PostDigBak()
        {
            DigBakDto response = new()
            {
                Code = 0,
                Message = "OK",
                Data = new DigBakDto.DataDto
                {
                    Data = string.Empty,
                    Res = "success",
                },
            };

            return Results.Json(response);
        }
    }
}
