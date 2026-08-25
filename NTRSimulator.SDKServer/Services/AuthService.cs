using NTRSimulator.Common.Manager;
using NTRSimulator.Database.Entities;
using NTRSimulator.Database.Services;
using NTRSimulator.SDKServer.Models;
using System;
using System.Security.Cryptography;
using System.Text;

namespace NTRSimulator.SDKServer.Services
{
    public interface IAuthService
    {
        AutoLoginDto EmailLogin(string email, string password);

        AutoLoginDto? AutoLogin(string accessToken);

        AccountInfoDto? GetAccountInfo(string accessToken);
    }

    public class AuthService(IAccountService accountService) : IAuthService
    {
        public AutoLoginDto EmailLogin(string email, string password)
        {
            var account = accountService.GetByEmail(email);

            if (account is null)
            {
                account = CreateAccount(email, password, isGuest: false);
            }
            else
            {
                if (account.PasswordHash != HashPassword(password))
                {
                    return new AutoLoginDto
                    {
                        Code = 10004,
                        Msg = "Incorrect password",
                    };
                }

                accountService.UpdateLastLogin(account, DateTime.UtcNow);
            }

            var accessToken = PlayerSessionManager.Instance.CreateSession(account.Uid, account.IsGuest);
            return BuildLoginDto(account, accessToken);
        }

        public AutoLoginDto? AutoLogin(string accessToken)
        {
            var session = PlayerSessionManager.Instance.GetSession(accessToken);
            if (session is null)
                return null;

            var account = accountService.GetByUid(session.Uid);
            if (account is null)
                return null;

            accountService.UpdateLastLogin(account, DateTime.UtcNow);

            return BuildLoginDto(account, accessToken);
        }

        public AccountInfoDto? GetAccountInfo(string accessToken)
        {
            var session = PlayerSessionManager.Instance.GetSession(accessToken);
            if (session is null)
                return null;

            var account = accountService.GetByUid(session.Uid);
            if (account is null)
                return null;

            return new AccountInfoDto
            {
                Code = 0,
                Msg = "OK",
                Data = new AccountInfoDto.DataDto
                {
                    Uid = (int)account.Uid,
                    Account = account.Email,
                    IsReal = 1,
                    IsGuest = account.IsGuest ? 1 : 0,
                    IsActivation = 1,
                    IsAdult = 1,
                    UnfreezeTime = 0,
                    Age = 18,
                    IdCards = string.Empty,
                    IdName = string.Empty,
                    CssToken = accessToken,
                    IsNeedSetPasswd = false,
                    UcAccountToken = accessToken,
                },
            };
        }

        private AccountEntity CreateAccount(string email, string password, bool isGuest)
        {
            var now = DateTime.UtcNow;
            return accountService.CreateAccount(email, HashPassword(password), isGuest, now);
        }

        private static AutoLoginDto BuildLoginDto(AccountEntity account, string accessToken)
        {
            return new AutoLoginDto
            {
                Code = 0,
                Msg = "OK",
                Data = new AutoLoginDto.DataDto
                {
                    AccessToken = accessToken,
                    IsReal = 1,
                    IsGuest = account.IsGuest ? 1 : 0,
                    IsActivation = 1,
                    IsAdult = 1,
                    UnfreezeTime = 0,
                    Age = 18,
                    Pi = string.Empty,
                    IsNeedSetPasswd = false,
                    UcAccountToken = accessToken,
                    Uid = (int)account.Uid,
                },
            };
        }

        private static string HashPassword(string password)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(bytes).ToLowerInvariant();
        }
    }
}
