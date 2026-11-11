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
            Log.Information($"HttpGet: {catchAll}  headers={string.Join(";", HttpContext.Request.Headers.Select(h => h.Key + "=" + h.Value))}");
            return Results.Empty;
        }

        private IResult PayExactQr()
        {
            string orderId = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            var payload = new Dictionary<string, object?>
            {
                ["code"] = 0,
                ["msg"] = "ok",
                ["data"] = new Dictionary<string, object?>
                {
                    // ★ 反汇编要求 inner 里这三个 key 必须都存在（get_Item 无 TryGetValue）
                    ["limit"] = 0,                      // 非对象值 → 不走限流回调
                    ["param"] = "https://gf2-zonepay.sunborngame.com/mock/qr?order=" + orderId,
                    ["order_id"] = orderId,
                },
            };
            Log.Information($"[PAY] 精确回包：data.param=二维码URL, data.order_id={orderId}");
            return Results.Json(payload);
        }

        [HttpPost("{*catchAll}")]
        public async Task<IResult> CatchAllPost(string catchAll)
        {
            string body = string.Empty;
            try
            {
                using var reader = new StreamReader(HttpContext.Request.Body);
                body = await reader.ReadToEndAsync();
            }
            catch { }

            Log.Information($"HttpPost: {catchAll}  headers={string.Join(";", HttpContext.Request.Headers.Select(h => h.Key + "=" + h.Value))}  body={body}");

            // ── SDK 的 /index 事件接口 ─────────────────────────────
            // 客户端日志显示：SDK 以 POST https://127.0.0.1/index 发送
            //   {"event":"heartbeat","sign":"...","openid":"...","game_channel_id":5,...}
            // 我们之前一律回空 → SDK 内部字典缺项 → CreateOrderByQR 里 KeyNotFound。
            // 这里记录事件名，并回一个正常结构，便于观察它到底问了哪些事件。
            if (catchAll.Contains("index", StringComparison.OrdinalIgnoreCase))
            {
                string evt = string.Empty;
                try
                {
                    using var doc = System.Text.Json.JsonDocument.Parse(body);
                    if (doc.RootElement.TryGetProperty("event", out var e)) evt = e.GetString() ?? "";
                }
                catch { }

                Log.Information($"[SDK] /index event={evt}");

                var sdkPayload = new Dictionary<string, object?>
                {
                    ["code"] = 0,
                    ["msg"] = "ok",
                    ["message"] = "ok",
                    ["event"] = evt,
                    ["data"] = new Dictionary<string, object?>(),
                    ["sign"] = "mock",
                };
                return Results.Json(sdkPayload);
            }


            // ── order/qr_confirm：轮询支付结果（返回 data=1 即已支付）──
            if (catchAll.Contains("qr_confirm", StringComparison.OrdinalIgnoreCase))
            {
                Log.Information($"[PAY] order/qr_confirm 请求体: {body}");
                // 反汇编 <RequestQROrderState>b__0 得到：
                //   d = data["data"]; int v = (int)d; if (v == 1) onOrderPaySuccess();
                // ⇒ 必须回整数 1
                Log.Information("[PAY] qr_confirm → 回 data=1（已支付）");
                return Results.Json(new Dictionary<string, object?>
                {
                    ["code"] = 0,
                    ["msg"] = "ok",
                    ["data"] = 1,
                });
            }

            // ── alipay|weixin/create_order_qr：登记发货 + 返回二维码结构 ──
            if (catchAll.Contains("create_order_qr", StringComparison.OrdinalIgnoreCase))
            {
                Log.Information($"[PAY] create_order_qr 请求体: {body}");

                try
                {
                    string subj = string.Empty, prod = string.Empty;
                    long amt = 0;
                    using (var doc = System.Text.Json.JsonDocument.Parse(body))
                    {
                        if (doc.RootElement.TryGetProperty("subject", out var s1)) subj = s1.GetString() ?? "";
                        if (doc.RootElement.TryGetProperty("product_id", out var s2)) prod = s2.GetString() ?? "";
                        if (doc.RootElement.TryGetProperty("amount", out var s3) &&
                            s3.ValueKind == System.Text.Json.JsonValueKind.Number) amt = s3.GetInt64();
                    }
                    System.IO.File.AppendAllText(Path.Combine(AppContext.BaseDirectory, "pending_purchase.txt"),
                        $"{prod}\t{amt}\t{subj.Replace("\t", " ")}\t{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}\n");
                    Log.Information($"[PAY] 已登记待发货: product={prod} amount={amt} subject={subj}");
                }
                catch (Exception ex) { Log.Warning($"[PAY] 登记失败: {ex.Message}"); }

                return PayExactQr();
            }

            return Results.Empty;
        }
    }
}
