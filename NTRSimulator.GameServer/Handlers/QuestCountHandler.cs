using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class QuestCountHandler : QuestCountHandlerBase
    {
        public override void HandleQuestCount(CS_QuestCount request, Connection connection)
        {
            connection.Send(1, new SC_QuestCount
            {
                Quest = new Quest
                {
                    DailyRewardsGroup = 1,
                    AlreadyReadQuests = { 7, 5, 10, 12, 11, 6 },
                    QuestSeqId = 0,
                    KEOFPBKDLEK = 1732339616,
                },
                Types_ =
                {
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)1, CounterType = (PlayerCounterSystem)16 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)3, CounterType = (PlayerCounterSystem)7 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)6, CounterType = (PlayerCounterSystem)9 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)9, CounterType = (PlayerCounterSystem)12 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)10, CounterType = (PlayerCounterSystem)1 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)11, CounterType = (PlayerCounterSystem)2 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)12, CounterType = (PlayerCounterSystem)3 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)13, CounterType = (PlayerCounterSystem)4 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)16, CounterType = (PlayerCounterSystem)18 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)19, CounterType = (PlayerCounterSystem)21 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)21, CounterType = (PlayerCounterSystem)26 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)22, CounterType = (PlayerCounterSystem)29 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)23, CounterType = (PlayerCounterSystem)31 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)24, CounterType = (PlayerCounterSystem)32 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)26, CounterType = (PlayerCounterSystem)34 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)27, CounterType = (PlayerCounterSystem)35 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)29, CounterType = (PlayerCounterSystem)38 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)30, CounterType = (PlayerCounterSystem)40 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)33, CounterType = (PlayerCounterSystem)43 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)34, CounterType = (PlayerCounterSystem)44 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)35, CounterType = (PlayerCounterSystem)45 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)36, CounterType = (PlayerCounterSystem)46 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)37, CounterType = (PlayerCounterSystem)47 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)38, CounterType = (PlayerCounterSystem)48 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)39, CounterType = (PlayerCounterSystem)49 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)40, CounterType = (PlayerCounterSystem)51 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)41, CounterType = (PlayerCounterSystem)52 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)42, CounterType = (PlayerCounterSystem)53 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)43, CounterType = (PlayerCounterSystem)54 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)44, CounterType = (PlayerCounterSystem)55 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)45, CounterType = (PlayerCounterSystem)56 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)46, CounterType = (PlayerCounterSystem)58 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)47, CounterType = (PlayerCounterSystem)59 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)48, CounterType = (PlayerCounterSystem)60 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)49, CounterType = (PlayerCounterSystem)62 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)50, CounterType = (PlayerCounterSystem)63 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)51, CounterType = (PlayerCounterSystem)64 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)52, CounterType = (PlayerCounterSystem)65 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)53, CounterType = (PlayerCounterSystem)66 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)54, CounterType = (PlayerCounterSystem)67 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)55, CounterType = (PlayerCounterSystem)68 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)56, CounterType = (PlayerCounterSystem)69 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)57, CounterType = (PlayerCounterSystem)70 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)58, CounterType = (PlayerCounterSystem)72 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)59, CounterType = (PlayerCounterSystem)73 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)60, CounterType = (PlayerCounterSystem)74 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)61, CounterType = (PlayerCounterSystem)75 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)62, CounterType = (PlayerCounterSystem)76 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)63, CounterType = (PlayerCounterSystem)77 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)64, CounterType = (PlayerCounterSystem)78 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)65, CounterType = (PlayerCounterSystem)80 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)67, CounterType = (PlayerCounterSystem)82 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)68, CounterType = (PlayerCounterSystem)83 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)70, CounterType = (PlayerCounterSystem)86 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)71, CounterType = (PlayerCounterSystem)85 },
                    new CounterTypeCombination { CommonType = (CommonQuestCounters.Types.Type)72, CounterType = (PlayerCounterSystem)87 },
                },
            });
        }
    }
}
