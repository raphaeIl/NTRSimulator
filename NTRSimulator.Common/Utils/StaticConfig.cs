namespace NTRSimulator.Common.Utils
{
    public static class StaticConfig
    {
        public const string GameServerHost = "127.0.0.1";

        public const int GameServerPort = 7001;

        public static string GameServerAddress => $"{GameServerHost}:{GameServerPort}";

        public static string ResourceDir = Path.Join(Path.GetDirectoryName(AppContext.BaseDirectory), "Resources");

        public static string PcapDir = Path.Join(ResourceDir, "Packets");

        public const string ClientVersion = "3.0.3531.0.0";

        public const string AbResourceVersion = "3.0.3531.13790.26703";

        public const string GameClientVersion = "3.0.3531";

        public const string StcVersion = "1145428";

        public const string ResUrlCdn = "https://gf2-cn.cdn.sunborngame.com/game_resources";

        public const string ResUrlOss = "https://gf2.oss-cn-beijing.aliyuncs.com/game_resources";

        public static string StcTableZipUrl => $"{ResUrlCdn}/data/{StcVersion}/bk_stc_pb.zip";

        public const string BinaryVersion = "3.0.3531.2901";

        public const string MustUpdateVersionClient = "13407.25794";

        public const string MustUpdateVersionBin = "2825";

        public const string MustUpdateVersionStc = "1128281";

        public const int GameNoticeListVersion = 1001;
    }
}
