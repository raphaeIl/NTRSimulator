using Microsoft.AspNetCore.Mvc;
using NTRSimulator.SDKServer.Models;
using NTRSimulator.SDKServer.Services;

namespace NTRSimulator.SDKServer.Controllers.Auth
{
    [ApiController]
    [Route("/account")]
    public class AccountController(IAuthService authService) : ControllerBase
    {
        [HttpPost("auto_login")]
        public IResult PostAutoLogin()
        {
            var accessToken = Request.Headers.Authorization.FirstOrDefault()
                           ?? string.Empty;

            if (string.IsNullOrWhiteSpace(accessToken))
            {
                return LoginFailureDto.Result(10004, "Invalid access token");
            }

            var result = authService.AutoLogin(accessToken);
            if (result is null)
            {
                return LoginFailureDto.Result(10004, "Invalid access token");
            }

            return Results.Json(result);
        }

        [HttpPost("info")]
        public IResult PostAccountInfo()
        {
            var accessToken = Request.Headers.Authorization.FirstOrDefault()
                           ?? string.Empty;

            if (string.IsNullOrWhiteSpace(accessToken))
            {
                return LoginFailureDto.Result(10004, "Invalid access token");
            }

            var result = authService.GetAccountInfo(accessToken);
            if (result is null)
            {
                return LoginFailureDto.Result(10004, "Invalid access token");
            }

            return Results.Json(result);
        }
    }
}
