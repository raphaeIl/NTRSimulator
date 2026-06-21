using NTRSimulator.Common.Utils;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NTRSimulator.Common.Manager
{
    public class PlayerSessionManager : Singleton<PlayerSessionManager>
    {
        private static readonly byte[] SigningKey = RandomNumberGenerator.GetBytes(32);

        private readonly ConcurrentDictionary<string, PlayerSession> _sessions = new();

        public string CreateSession(uint uid, bool isGuest)
        {
            var token = GenerateAccessToken(uid, isGuest);
            var session = new PlayerSession(uid, token, DateTime.UtcNow);

            _sessions[token] = session;
            return token;
        }

        public PlayerSession? GetSession(string accessToken)
        {
            if (!VerifyAccessToken(accessToken))
                return null;

            _sessions.TryGetValue(accessToken, out var session);
            return session;
        }

        public void RemoveSession(string accessToken)
        {
            _sessions.TryRemove(accessToken, out _);
        }

        private static string GenerateAccessToken(uint uid, bool isGuest)
        {
            var openId = Convert.ToHexString(RandomNumberGenerator.GetBytes(12)).ToLowerInvariant();
            var expires = DateTimeOffset.UtcNow.AddDays(7).ToUnixTimeSeconds();

            var payload = new AccessTokenPayload
            {
                OpenId = openId,
                Expires = expires,
                IsGuest = isGuest ? 1 : 0,
                Uid = uid,
            };

            var payloadJson = JsonSerializer.Serialize(payload);
            var payloadBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(payloadJson));

            var signature = HMACSHA256.HashData(SigningKey, Encoding.UTF8.GetBytes(payloadBase64));
            var signatureBase64 = Convert.ToBase64String(signature);

            return $"{payloadBase64}.{signatureBase64}";
        }

        private static bool VerifyAccessToken(string accessToken)
        {
            var dotIndex = accessToken.IndexOf('.');
            if (dotIndex <= 0 || dotIndex >= accessToken.Length - 1)
                return false;

            var payloadBase64 = accessToken[..dotIndex];
            var signatureBase64 = accessToken[(dotIndex + 1)..];

            byte[] expectedSignature;
            try
            {
                expectedSignature = HMACSHA256.HashData(SigningKey, Encoding.UTF8.GetBytes(payloadBase64));
            }
            catch
            {
                return false;
            }

            byte[] actualSignature;
            try
            {
                actualSignature = Convert.FromBase64String(signatureBase64);
            }
            catch (FormatException)
            {
                return false;
            }

            return CryptographicOperations.FixedTimeEquals(expectedSignature, actualSignature);
        }

        private class AccessTokenPayload
        {
            [JsonPropertyName("openid")]
            public string OpenId { get; set; } = string.Empty;

            [JsonPropertyName("expires")]
            public long Expires { get; set; }

            [JsonPropertyName("is_guest")]
            public int IsGuest { get; set; }

            [JsonPropertyName("uid")]
            public uint Uid { get; set; }
        }
    }

    public record PlayerSession(uint Uid, string AccessToken, DateTime CreatedAt);
}
