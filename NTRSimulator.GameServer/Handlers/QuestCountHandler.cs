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
                Field1 = new SC_QuestCount_F1Type
                {
                    Field12 = 1,
                    Field13 = { 7, 5, 10, 12, 11, 6 },
                    Field17 = 0,
                    Field18 = 1732339616,
                },
                Field2 =
                {
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)1, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)16 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)3, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)7 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)6, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)9 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)9, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)12 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)10, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)1 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)11, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)2 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)12, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)3 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)13, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)4 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)16, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)18 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)19, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)21 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)21, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)26 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)22, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)29 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)23, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)31 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)24, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)32 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)26, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)34 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)27, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)35 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)29, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)38 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)30, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)40 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)33, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)43 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)34, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)44 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)35, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)45 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)36, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)46 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)37, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)47 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)38, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)48 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)39, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)49 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)40, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)51 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)41, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)52 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)42, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)53 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)43, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)54 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)44, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)55 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)45, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)56 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)46, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)58 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)47, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)59 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)48, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)60 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)49, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)62 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)50, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)63 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)51, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)64 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)52, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)65 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)53, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)66 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)54, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)67 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)55, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)68 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)56, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)69 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)57, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)70 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)58, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)72 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)59, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)73 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)60, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)74 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)61, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)75 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)62, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)76 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)63, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)77 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)64, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)78 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)65, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)80 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)67, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)82 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)68, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)83 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)70, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)86 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)71, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)85 },
                    new SC_QuestCount_F2Type { Field1 = (Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare)72, Field2 = (Enum_CounterSystemNone_CounterSystemAchievement_CounterSystemGuideQuest_CounterSystemDailyQuest_CounterSystemWeeklyQuest)87 },
                },
            });
        }
    }
}
