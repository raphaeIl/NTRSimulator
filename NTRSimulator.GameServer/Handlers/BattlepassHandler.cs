using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class BattlepassHandler : BattlepassHandlerBase
    {
        public override void HandleGetBattlepassInfo(CS_GetBattlepassInfo request, Connection connection)
        {
                    connection.Send(new SC_GetBattlepassInfo
                    {
                        Battlepass = new Battlepass
                        {
                            Status = 0,
                            Reward = { [1] = 0 },
                            Exp = 0,
                            CurrId = 30034,
                            LeftRewardNum = 1,
                            DailyTask = { 34001, 34002, 34003, 34004 },
                            WeeklyTask = { 34013, 34009, 34015, 34010, 34012, 34016, 34007, 34014, 34008 },
                            ExtraTask = { },
                            ShareTask = { },
                            ReleseTask = { },
                            AcceptTaskinfo = { },
                            RefreshTime = 0,
                            MaxLevelReward = false,
                            OPJONAGNMKE = { 34018, 34019, 34022, 34020, 34021, 34017 },
                        },
                        ShareExpire = 0,
                    });
        }

    }
}
