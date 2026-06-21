using Google.Protobuf;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using Serilog;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class GachaHandler : GachaHandlerBase
    {
        public override void HandleGetGachaCumulativeInfo(CS_GetGachaCumulativeInfo request, Connection connection)
        {
            connection.Send(new SC_GetGachaCumulativeInfo
            {
                Field1 = { },
            });
        }

        public override void HandleGachaTentimes(CS_GachaTentimes request, Connection connection)
        {
            // MsgScRecordStatisticUpdate
            SC_RecordStatisticUpdate scRecordStatisticUpdate = new()
            {
                Field1 = 1,
                Field2 = 1
            };
            connection.Send(scRecordStatisticUpdate);
            
            SC_GachaAcquirement gachaAqu = new SC_GachaAcquirement()
            {
                Field3 = 234001,
                Field2 = null,
                Field1 =
                {
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 11030,
                        Field2 = 1,
                        Field6 = 16,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 1022,
                        Field2 = 1,
                        Field6 = 0,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = (Enum_NoneNull_UserUpgradeReward_TakeAchieveRewards_TakeAchieveTagReward_RecordRoomGetDetailReward)62,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 11048,
                        Field2 = 1,
                        Field6 = 18,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 11042,
                        Field2 = 1,
                        Field6 = 19,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 10631,
                        Field2 = 1,
                        Field6 = 20,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 11010,
                        Field2 = 1,
                        Field6 = 21,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 11009,
                        Field2 = 1,
                        Field6 = 22,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 11039,
                        Field2 = 1,
                        Field6 = 23,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 11022,
                        Field2 = 1,
                        Field6 = 24,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                    new SC_DarkZoneEndContract_F4Type()
                    {
                        Field1 = 11008,
                        Field2 = 1,
                        Field6 = 25,
                        Field7 = 0,
                        Field4 = { },
                        Field8 = { },
                        Field9 = false,
                        Field10 = 0,
                        Field11 = null,
                        Field12 = 0,
                    },
                },
                Field5 = null,
                Field4 = 10,
                Field6 =
                {
                    { 110001, 60 },
                    { 155001, 70 },
                    { 50001, 70 },
                    { 8001, 70 },
                    { 81001, 60 },
                    { 191001, 60 },
                    { 203001, 60 },
                    { 91001, 70 },
                    { 60001, 70 },
                    { 133001, 70 },
                    { 6001, 60 },
                    { 199001, 60 },
                    { 229001, 70 },
                    { 233001, 70 },
                    { 100001, 60 },
                    { 35001, 60 },
                    { 234001, 60 },
                    { 10001, 70 },
                    { 123001, 70 },
                    { 166001, 80 },
                    { 75001, 60 },
                    { 17001, 60 },
                    { 167001, 70 },
                    { 139001, 70 },
                    { 67001, 60 },
                    { 128001, 60 },
                    { 1101, 79 },
                    { 149001, 70 },
                    { 193001, 60 },
                    { 43001, 60 },
                    { 32001, 70 },
                    { 225001, 70 },
                    { 11001, 60 },
                    { 71001, 60 },
                    { 37001, 60 },
                    { 157001, 70 },
                    { 145001, 70 },
                    { 101001, 70 },
                    { 208001, 70 },
                    { 188001, 100 },
                    { 56001, 70 },
                    { 116001, 60 },
                    { 170001, 60 },
                    { 227001, 70 },
                    { 179001, 70 },
                    { 177001, 70 },
                    { 213001, 60 },
                    { 13001, 60 },
                    { 211001, 60 },
                    { 195001, 60 },
                    { 46001, 70 },
                    { 85001, 60 },
                    { 194001, 70 },
                    { 148001, 60 },
                    { 117001, 70 },
                    { 115001, 70 },
                    { 26001, 70 },
                    { 239001, 70 },
                    { 22001, 70 },
                    { 23001, 60 },
                    { 65001, 60 },
                    { 80001, 70 },
                    { 127001, 70 },
                    { 159001, 70 },
                    { 189001, 60 },
                    { 132001, 60 },
                    { 142001, 60 },
                    { 38001, 70 },
                    { 190001, 70 },
                    { 83001, 60 },
                    { 172001, 60 },
                    { 39001, 60 },
                    { 217001, 60 },
                    { 138001, 60 },
                    { 222001, 60 },
                    { 106001, 60 },
                    { 49001, 60 },
                    { 72001, 70 },
                    { 156001, 60 },
                    { 129001, 70 },
                    { 45001, 60 },
                    { 105001, 70 },
                    { 212001, 70 },
                    { 52001, 70 },
                    { 70001, 70 },
                    { 77001, 60 },
                    { 165001, 70 },
                    { 214001, 70 },
                    { 14001, 70 },
                    { 122001, 60 },
                    { 63001, 60 },
                    { 21001, 60 },
                    { 135001, 70 },
                    { 119001, 70 },
                    { 15001, 60 },
                    { 90021, 80 },
                    { 68001, 70 },
                    { 55001, 60 },
                    { 221001, 100 },
                    { 228001, 60 },
                    { 224001, 60 },
                    { 91011, 70 },
                    { 12001, 70 },
                    { 187001, 70 },
                    { 111001, 70 },
                    { 182001, 60 },
                    { 42001, 70 },
                    { 210001, 70 },
                    { 54001, 70 },
                    { 175001, 70 },
                    { 118001, 60 },
                    { 44001, 70 },
                    { 5001, 70 },
                    { 84001, 70 },
                    { 113001, 70 },
                    { 207001, 60 },
                    { 62001, 70 },
                    { 126001, 60 },
                    { 69001, 60 },
                    { 18001, 70 },
                    { 121001, 70 },
                    { 104001, 60 },
                    { 87001, 60 },
                    { 163001, 70 },
                    { 31001, 60 },
                    { 197001, 60 },
                    { 174001, 60 },
                    { 215001, 60 },
                    { 53001, 60 },
                    { 25001, 60 },
                    { 168001, 60 },
                    { 216001, 70 },
                    { 82001, 70 },
                    { 20001, 70 },
                    { 238001, 60 },
                    { 112001, 60 },
                    { 48001, 70 },
                    { 141001, 70 },
                    { 230001, 60 },
                    { 232001, 60 },
                    { 57001, 60 },
                    { 236001, 60 },
                    { 186001, 80 },
                    { 107001, 70 },
                    { 64001, 70 },
                    { 173001, 70 },
                    { 218001, 70 },
                    { 41001, 60 },
                    { 91021, 70 },
                    { 74001, 70 },
                    { 235001, 70 },
                    { 59001, 60 },
                    { 151001, 70 },
                    { 164001, 60 },
                    { 1001, 79 },
                    { 90001, 80 },
                    { 66001, 70 },
                    { 103001, 70 },
                    { 160001, 60 },
                    { 220001, 70 },
                    { 192001, 70 },
                    { 102001, 60 },
                    { 134001, 60 },
                    { 137001, 70 },
                    { 33001, 60 },
                    { 29001, 60 },
                    { 144001, 60 },
                    { 114001, 60 },
                    { 209001, 60 },
                    { 161001, 70 },
                    { 40001, 70 },
                    { 4001, 50 },
                    { 202001, 70 },
                    { 47001, 60 },
                    { 180001, 60 },
                    { 205001, 60 },
                    { 36001, 70 },
                    { 108001, 60 },
                    { 9001, 60 },
                    { 152001, 60 },
                    { 3001, 60 },
                    { 154001, 60 },
                    { 109001, 70 },
                    { 61001, 60 },
                    { 136001, 60 },
                    { 226001, 60 },
                    { 125001, 70 },
                    { 171001, 70 },
                    { 237001, 70 },
                    { 201001, 60 },
                    { 143001, 70 },
                    { 147001, 70 },
                    { 158001, 60 },
                    { 181001, 70 },
                    { 131001, 70 },
                    { 51001, 60 },
                    { 198001, 70 },
                    { 91031, 70 },
                    { 206001, 70 },
                    { 78001, 70 },
                    { 30001, 70 },
                    { 34001, 70 },
                    { 76001, 70 },
                    { 124001, 60 },
                    { 79001, 60 },
                    { 86001, 70 },
                    { 28001, 70 },
                    { 58001, 70 },
                    { 27001, 60 },
                    { 183001, 70 },
                    { 2001, 70 },
                    { 16001, 70 },
                    { 146001, 60 },
                    { 7001, 60 },
                    { 219001, 80 },
                    { 223001, 70 },
                    { 120001, 60 },
                    { 184001, 60 },
                    { 185001, 70 },
                    { 204001, 70 },
                    { 88001, 70 },
                    { 90031, 80 },
                    { 98001, 100 },
                    { 196001, 70 },
                    { 4101, 50 },
                    { 162001, 60 },
                    { 178001, 60 },
                    { 140001, 60 },
                    { 90011, 80 },
                    { 153001, 70 },
                    { 231001, 70 },
                    { 130001, 60 },
                    { 150001, 80 },
                    { 176001, 60 },
                    { 73001, 60 },
                    { 19001, 60 },
                    { 200001, 70 },
                    { 24001, 70 },
                    { 169001, 70 },
                },
                Field7 = 1,
                Field8 = false,
                Field9 = null,
            };

            SC_GachaAcquirement gachaAquSkin = new SC_GachaAcquirement()
            {
                Field3 = 221001,
                Field2 = null,
                Field1 =
                {

                },
                Field5 = null,
                Field4 = 10,
                Field6 =
                {
                    { 1001, 80 },
                    { 1101, 80 },
                    { 2001, 66 },
                    { 3001, 73 },
                    { 4001, 49 },
                    { 4101, 50 },
                    { 5001, 66 },
                    { 6001, 73 },
                    { 7001, 73 },
                    { 8001, 66 },
                    { 9001, 73 },
                    { 10001, 66 },
                    { 11001, 73 },
                    { 12001, 66 },
                    { 13001, 73 },
                    { 14001, 66 },
                    { 15001, 73 },
                    { 16001, 66 },
                    { 17001, 73 },
                    { 18001, 66 },
                    { 19001, 73 },
                    { 20001, 66 },
                    { 21001, 73 },
                    { 22001, 66 },
                    { 23001, 73 },
                    { 24001, 66 },
                    { 25001, 73 },
                    { 26001, 66 },
                    { 27001, 73 },
                    { 28001, 66 },
                    { 29001, 73 },
                    { 30001, 66 },
                    { 31001, 73 },
                    { 32001, 66 },
                    { 33001, 73 },
                    { 34001, 66 },
                    { 35001, 73 },
                    { 36001, 66 },
                    { 37001, 73 },
                    { 38001, 66 },
                    { 39001, 73 },
                    { 40001, 66 },
                    { 41001, 73 },
                    { 42001, 66 },
                    { 43001, 73 },
                    { 44001, 66 },
                    { 45001, 73 },
                    { 46001, 66 },
                    { 47001, 73 },
                    { 48001, 66 },
                    { 49001, 73 },
                    { 50001, 66 },
                    { 51001, 73 },
                    { 52001, 66 },
                    { 53001, 73 },
                    { 54001, 66 },
                    { 55001, 73 },
                    { 56001, 66 },
                    { 57001, 73 },
                    { 58001, 66 },
                    { 59001, 73 },
                    { 60001, 66 },
                    { 61001, 73 },
                    { 62001, 66 },
                    { 63001, 73 },
                    { 64001, 66 },
                    { 65001, 73 },
                    { 66001, 66 },
                    { 67001, 73 },
                    { 68001, 66 },
                    { 69001, 73 },
                    { 70001, 66 },
                    { 71001, 73 },
                    { 72001, 66 },
                    { 73001, 73 },
                    { 74001, 66 },
                    { 75001, 73 },
                    { 76001, 66 },
                    { 77001, 73 },
                    { 78001, 66 },
                    { 79001, 73 },
                    { 80001, 66 },
                    { 81001, 73 },
                    { 82001, 66 },
                    { 83001, 73 },
                    { 84001, 66 },
                    { 85001, 73 },
                    { 86001, 66 },
                    { 87001, 73 },
                    { 88001, 66 },
                    { 90001, 80 },
                    { 90011, 80 },
                    { 90021, 80 },
                    { 90031, 80 },
                    { 91001, 70 },
                    { 91011, 70 },
                    { 91021, 70 },
                    { 91031, 70 },
                    { 98001, 99 },
                    { 100001, 73 },
                    { 101001, 66 },
                    { 102001, 73 },
                    { 103001, 66 },
                    { 104001, 73 },
                    { 105001, 66 },
                    { 106001, 73 },
                    { 107001, 66 },
                    { 108001, 73 },
                    { 109001, 66 },
                    { 110001, 73 },
                    { 111001, 66 },
                    { 112001, 73 },
                    { 113001, 66 },
                    { 114001, 73 },
                    { 115001, 66 },
                    { 116001, 73 },
                    { 117001, 66 },
                    { 118001, 73 },
                    { 119001, 66 },
                    { 120001, 73 },
                    { 121001, 66 },
                    { 122001, 73 },
                    { 123001, 66 },
                    { 124001, 73 },
                    { 125001, 66 },
                    { 126001, 73 },
                    { 127001, 66 },
                    { 128001, 73 },
                    { 129001, 66 },
                    { 130001, 73 },
                    { 131001, 66 },
                    { 132001, 73 },
                    { 133001, 66 },
                    { 134001, 73 },
                    { 135001, 66 },
                    { 136001, 73 },
                    { 137001, 66 },
                    { 138001, 73 },
                    { 139001, 66 },
                    { 140001, 73 },
                    { 141001, 66 },
                    { 142001, 73 },
                    { 143001, 66 },
                    { 144001, 73 },
                    { 145001, 66 },
                    { 146001, 73 },
                    { 147001, 66 },
                    { 148001, 73 },
                    { 149001, 66 },
                    { 150001, 76 },
                    { 151001, 70 },
                    { 152001, 73 },
                    { 153001, 66 },
                    { 154001, 73 },
                    { 155001, 66 },
                    { 156001, 73 },
                    { 157001, 66 },
                    { 158001, 73 },
                    { 159001, 66 },
                    { 160001, 73 },
                    { 161001, 66 },
                    { 162001, 73 },
                    { 163001, 66 },
                    { 164001, 73 },
                    { 165001, 66 },
                    { 166001, 80 },
                    { 167001, 62 },
                    { 168001, 73 },
                    { 169001, 66 },
                    { 170001, 73 },
                    { 171001, 66 },
                    { 172001, 73 },
                    { 173001, 66 },
                    { 174001, 73 },
                    { 175001, 66 },
                    { 176001, 73 },
                    { 177001, 66 },
                    { 178001, 73 },
                    { 179001, 66 },
                    { 180001, 73 },
                    { 181001, 66 },
                    { 182001, 73 },
                    { 183001, 66 },
                    { 184001, 73 },
                    { 185001, 66 },
                    { 186001, 80 },
                    { 187001, 66 },
                    { 188001, 100 },
                    { 189001, 73 },
                    { 190001, 66 },
                    { 191001, 73 },
                    { 192001, 66 },
                    { 193001, 73 },
                    { 194001, 66 },
                    { 195001, 73 },
                    { 196001, 66 },
                    { 197001, 73 },
                    { 198001, 66 },
                    { 199001, 73 },
                    { 200001, 66 },
                    { 201001, 73 },
                    { 202001, 66 },
                    { 203001, 73 },
                    { 204001, 66 },
                    { 205001, 73 },
                    { 206001, 66 },
                    { 207001, 73 },
                    { 208001, 66 },
                    { 209001, 73 },
                    { 210001, 66 },
                    { 211001, 73 },
                    { 212001, 66 },
                    { 213001, 73 },
                    { 214001, 66 },
                    { 215001, 73 },
                    { 216001, 66 },
                    { 217001, 73 },
                    { 218001, 66 },
                    { 219001, 80 },
                    { 220001, 70 },
                    { 221001, 90 },
                    { 222001, 73 },
                    { 223001, 66 },
                    { 224001, 73 },
                    { 225001, 66 },
                    { 226001, 73 },
                    { 227001, 66 },
                    { 228001, 73 },
                    { 229001, 66 },
                    { 230001, 73 },
                    { 231001, 66 },
                    { 232001, 73 },
                    { 233001, 66 },
                    { 234001, 73 },
                    { 235001, 66 },
                    { 236001, 73 },
                    { 237001, 66 },
                    { 238001, 73 },
                    { 239001, 66 },
                },
                Field7 = 722,
                Field8 = false,
                Field9 = null,
            };

            SC_PlayerStatusCounterSync playerStatusCounterSync = new()
            {
                Field2 = 11,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 48027 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000007 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000013 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000014 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000019 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000003 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000006 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000016 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000018 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 1023 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000017 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000021 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000009 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000026 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000027 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000028 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000008 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000024 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000025 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000004 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000005 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000012 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000020 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000001 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000002 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000011 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000022 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000023 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000010 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 3000015 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 30, Field2 = 22010 },
                },
            };
            SC_AddIndex addIndex = new SC_AddIndex()
            {
                Field1 = 60,
                Field2 = 3114663,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync2 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 6,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1311 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync3 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 39, Field2 = 60045 },
                },
            };
            SC_NewGunWeapon newGunWeapon = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 6,
                    WeaponId = 11036,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_AddIndex addIndex2 = new SC_AddIndex()
            {
                Field1 = 20,
                Field2 = 11036,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync6 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 4,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 48026 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 30, Field2 = 22009 },
                },
            };
            SC_AddIndex addIndex3 = new SC_AddIndex()
            {
                Field1 = 60,
                Field2 = 3111703,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync8 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 7,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1311 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync9 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 39, Field2 = 60049 },
                },
            };
            SC_NewGunWeapon newGunWeapon2 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 7,
                    WeaponId = 11048,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_GunWeaponBelong gunWeaponBelong = new SC_GunWeaponBelong()
            {
                WeaponId = 7,
                GunId = 1026,
            };
            SC_AddIndex addIndex4 = new SC_AddIndex()
            {
                Field1 = 20,
                Field2 = 11048,
                Field3 = 0,
            };
            SC_NewGun newGun = new SC_NewGun()
            {
                Field1 = new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F12Type()
                {
                    GunId = 1026,
                    Field41 = 0,
                    CreateTime = 1779518872,
                    Level = 1,
                    AscensionLevel = 1,
                    CostumeId = 1102600,
                    Field54 = 0,
                    GunClass = 0,
                    Exp = 120,
                    Field42 = { 0, 0, 0 },
                    Field43 = { 0, 0, 0 },
                    Field45 = { 0, 0, 0 },
                    TalentTree = { },
                    IsGetPublicTalentSkillItem = false,
                    Preset = 0,
                    GunTalentConsume = { },
                    TalentResetNum = 0,
                    Details = null,
                    AuthLevel = 0,
                    IsAllTalentUnlock = false,
                    Field50 = new BattleReplayNbcopResult_F4Type_F3Type_F101Type_F12Type_F50Type()
                    {
                        Field1 = 1,
                        Field2 = 0,
                        Field3 = 0,
                        Field4 = false,
                        Field5 = 0,
                    },
                    Field51 = { },
                    Field52 = { 0 },
                    Favorite = 0,
                    Field55 = { },
                    Field56 = 0,
                    GunBattleAiPreset = null,
                    Field58 = 0,
                    Field59 = { 0 },
                    Field60 = { 0 },
                    Field61 = 0,
                    Field62 = 7,
                },
            };
            SC_AddIndex addIndex5 = new SC_AddIndex()
            {
                Field1 = 10,
                Field2 = 1026,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync15 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1351 },
                },
            };
            SC_AddIndex addIndex6 = new SC_AddIndex()
            {
                Field1 = 13,
                Field2 = 1102600,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync17 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 5,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 48026 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 30, Field2 = 22009 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync18 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 2,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1241 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync19 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 5,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1341 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync20 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402606 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402607 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402608 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402601 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402602 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402603 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402604 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402605 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync21 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402609 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 1, Field2 = 402610 },
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 49, Field2 = 102611 },
                },
            };
            SC_AddIndex addIndex7 = new SC_AddIndex()
            {
                Field1 = 60,
                Field2 = 3116693,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync23 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 8,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1311 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync24 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 39, Field2 = 60048 },
                },
            };
            SC_NewGunWeapon newGunWeapon3 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 8,
                    WeaponId = 11045,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_AddIndex addIndex8 = new SC_AddIndex()
            {
                Field1 = 20,
                Field2 = 11045,
                Field3 = 0,
            };
            SC_AddIndex addIndex9 = new SC_AddIndex()
            {
                Field1 = 60,
                Field2 = 3116623,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync28 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 9,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1311 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync29 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 39, Field2 = 60041 },
                },
            };
            SC_NewGunWeapon newGunWeapon4 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 9,
                    WeaponId = 11017,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_AddIndex addIndex10 = new SC_AddIndex()
            {
                Field1 = 20,
                Field2 = 11017,
                Field3 = 0,
            };
            SC_NewGunWeapon newGunWeapon5 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 10,
                    WeaponId = 11039,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_AddIndex addIndex11 = new SC_AddIndex()
            {
                Field1 = 60,
                Field2 = 3111583,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync34 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 10,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1311 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync35 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 39, Field2 = 60222 },
                },
            };
            SC_NewGunWeapon newGunWeapon6 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 11,
                    WeaponId = 10631,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_AddIndex addIndex12 = new SC_AddIndex()
            {
                Field1 = 20,
                Field2 = 10631,
                Field3 = 0,
            };
            SC_AddIndex addIndex13 = new SC_AddIndex()
            {
                Field1 = 60,
                Field2 = 3111753,
                Field3 = 0,
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync39 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 11,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 63, Field2 = 1311 },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync40 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 1,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 39, Field2 = 60054 },
                },
            };
            SC_NewGunWeapon newGunWeapon7 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 12,
                    WeaponId = 10361,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_AddIndex addIndex14 = new SC_AddIndex()
            {
                Field1 = 20,
                Field2 = 10361,
                Field3 = 0,
            };
            SC_NewGunWeapon newGunWeapon8 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 13,
                    WeaponId = 11009,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_PlayerStatusCounterSync playerStatusCounterSync44 = new SC_PlayerStatusCounterSync()
            {
                Field2 = 2,
                Field1 =
                {
                    new SC_PlayerStatusCounterSync_F1Type() { Field1 = 39, Field2 = 60054 },
                },
            };
            SC_NewGunWeapon newGunWeapon9 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 14,
                    WeaponId = 10361,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_NewGunWeapon newGunWeapon10 = new SC_NewGunWeapon()
            {
                GunWeapon = new GunWeapon()
                {
                    Id = 15,
                    WeaponId = 11010,
                    Level = 1,
                    CurExp = 0,
                    Field5 = 0,
                    BreakTimes = 1,
                    GunId = 2,
                    ModSlots = { },
                },
            };
            SC_CommonQuestCountUpdate commonQuestCountUpdate = new SC_CommonQuestCountUpdate()
            {
                Field1 = new SC_CommonQuestCountReset_F1Type()
                {
                    Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.Guide,
                    Field4 =
                    {
                        { 3000001, false },
                        { 402601, false },
                        { 40001, false },
                        { 44012, false },
                        { 44015, false },
                        { 46032, false },
                        { 71007, false },
                    },
                    Field5 = { },
                    Field6 = { },
                },
            };
            SC_ResourceUpdate resourceUpdate = new SC_ResourceUpdate()
            {
                Field2 =
                {
                    { 45, 93 },
                    { 16, 18 },
                    { 47, 24 },
                },
            };
            SC_AddIndex addIndex15 = new SC_AddIndex()
            {
                Field1 = 37,
                Field2 = 23023,
                Field3 = 1779518872,
            };
            SC_OutfitCollectionScoreUpdate outfitCollectionScoreUpdate = new SC_OutfitCollectionScoreUpdate()
            {
                Field1 = 62,
            };
            SC_AddIndex addIndex16 = new SC_AddIndex()
            {
                Field1 = 12,
                Field2 = 21011,
                Field3 = 0,
            };
            SC_OutfitCollectionScoreUpdate outfitCollectionScoreUpdate2 = new SC_OutfitCollectionScoreUpdate()
            {
                Field1 = 64,
            };
            SC_CommonQuestCountUpdate commonQuestCountUpdate2 = new SC_CommonQuestCountUpdate()
            {
                Field1 = new SC_CommonQuestCountReset_F1Type()
                {
                    Field1 = Enum_WeeklySimCombat_PvpDailyPoints_PvpGuide_BattlepassDaily_BattlepassShare.LoadingPicture,
                    Field4 =
                    {
                        { 1311, false },
                    },
                    Field5 = { },
                    Field6 =
                    {
                        { 1311, 1779518872 },
                    },
                },
            };

            SC_DarkZoneEndContract_F4Type CreateItem(uint itemId, uint amount)
            {
                return new SC_DarkZoneEndContract_F4Type()
                {
                    Field1 = itemId,
                    Field2 = amount,
                    Field6 = 0,
                    Field7 = 0,
                    Field4 = { },
                    Field8 = { },
                    Field9 = false,
                    Field10 = (Enum_NoneNull_UserUpgradeReward_TakeAchieveRewards_TakeAchieveTagReward_RecordRoomGetDetailReward)62,
                    Field11 = null,
                    Field12 = 0,
                };
            }

            // normal 
            // 3d dorm skin 221001
            SC_GachaAcquirement gachaAquirementResp = null;

            if (request.Field1 == 221001)
            {
                //GachaClothesData
                // 31083 可露凯ssr, 31086 安朵丝sr, 31096罗蕾莱ssr, 31097, 31095莱娅ssr, 31107
                uint[] skinPool = [31083, 31096, 31095];

                for (int i = 0; i < 10; i++)
                {
                    gachaAquSkin.Field1.Add(CreateItem(skinPool[Random.Shared.Next(skinPool.Length)], 999));
                }

                //gachaAquSkin.Field1.Add(CreateItem(210150101, 1));
                //gachaAquSkin.Field1.Add(CreateItem(210150601, 1));
                //gachaAquSkin.Field1.Add(CreateItem(300021, 1));
                //gachaAquSkin.Field1.Add(CreateItem(210150101, 1));
                //gachaAquSkin.Field1.Add(CreateItem(31019, 1));
                //gachaAquSkin.Field1.Add(CreateItem(506, 1));

                for (int i = 0; i < 20; i++)
                {
                    gachaAquSkin.Field1.Add(CreateItem(1032, 999));
                }

                gachaAquirementResp = gachaAquSkin;
            }

            else
            {
                List<uint> history = new List<uint>();

                foreach (var ch in gachaAqu.Field1)
                {
                    do
                    {
                        //ch.Field1 = (uint)Random.Shared.Next(1020, 1063);

                        ch.Field1 = 1078;
                        // 1032 daiyan
                    } while (ch.Field1 == 1038 || ch.Field1 == 1060 || ch.Field1 == 1041 || ch.Field1 == 1026 || ch.Field1 == 1036 || ch.Field1 == 1022 || ch.Field1 == 1024);

                    history.Add(ch.Field1);
                    Log.Information("Got character {char}", ch.Field1);
                }

                gachaAquirementResp = gachaAqu;
            }

            //"9B 00 00 61 0C"
            connection.SendAutoEncrypted<IMessage>(
                    playerStatusCounterSync,
                    addIndex,
                    playerStatusCounterSync2,
                    playerStatusCounterSync3,
                    newGunWeapon,
                    addIndex2,
                    playerStatusCounterSync6,
                    addIndex3,
                    playerStatusCounterSync8,
                    playerStatusCounterSync9,
                    newGunWeapon2,
                    gunWeaponBelong,
                    addIndex4,
                    newGun,
                    addIndex5,
                    playerStatusCounterSync15,
                    addIndex6,
                    playerStatusCounterSync17,
                    playerStatusCounterSync18,
                    playerStatusCounterSync19,
                    playerStatusCounterSync20,
                    playerStatusCounterSync21,
                    addIndex7,
                    playerStatusCounterSync23,
                    playerStatusCounterSync24,
                    newGunWeapon3,
                    addIndex8,
                    addIndex9,
                    playerStatusCounterSync28,
                    playerStatusCounterSync29,
                    newGunWeapon4,
                    addIndex10,
                    newGunWeapon5,
                    addIndex11,
                    playerStatusCounterSync34,
                    playerStatusCounterSync35,
                    newGunWeapon6,
                    addIndex12,
                    addIndex13,
                    playerStatusCounterSync39,
                    playerStatusCounterSync40,
                    newGunWeapon7,
                    addIndex14,
                    newGunWeapon8,
                    playerStatusCounterSync44,
                    newGunWeapon9,
                    newGunWeapon10,

                    gachaAquirementResp,

                    commonQuestCountUpdate,
                    resourceUpdate,
                    addIndex15,
                    outfitCollectionScoreUpdate,
                    addIndex16,
                    outfitCollectionScoreUpdate2,
                    commonQuestCountUpdate2);
        }

    }
}
