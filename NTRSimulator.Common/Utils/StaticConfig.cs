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

        public const string AbResourceVersion = "3.0.3531.12401.24054";

        public const string GameClientVersion = "3.0.3531";

        public const string StcVersion = "1093303";

        public const string BinaryVersion = "3.0.3531.2689";

        public const string MustUpdateVersionClient = "11192.21670";

        public const string MustUpdateVersionBin = "2343";

        public const string MustUpdateVersionStc = "1048877";

        public const int GameNoticeListVersion = 1001;
    }
}
