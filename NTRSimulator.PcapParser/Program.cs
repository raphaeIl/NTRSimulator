using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace NTRSimulator.PcapParser
{
    public class Program
    {
        public static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                .CreateLogger();

            try
            {
                string pcapDirPath = NTRSimulator.Common.Utils.StaticConfig.PcapDir;
                if (!Directory.Exists(pcapDirPath))
                {
                    Log.Error("Pcap directory does not exist: {PcapDirectory}", pcapDirPath);
                    return;
                }

                string[] pcapFilePaths = Directory
                    .EnumerateFiles(pcapDirPath)
                    .Where(path => path.EndsWith(".pcap", StringComparison.OrdinalIgnoreCase))
                    .OrderBy(path => path, StringComparer.OrdinalIgnoreCase)
                    .ToArray();

                if (pcapFilePaths.Length == 0)
                {
                    Log.Warning("No .pcap files found in {PcapDirectory}", pcapDirPath);
                    return;
                }

                PcapParser parser = new(PcapParserMode.Official);
                parser.EnableVerboseLogging = true;
                foreach (string pcapFilePath in pcapFilePaths)
                {
                    try
                    {
                        parser.ParsePackets(pcapFilePath);
                        string outputPath = Path.ChangeExtension(pcapFilePath, ".json");
                        parser.SavePackets(outputPath);
                        Log.Information(
                            "Saved {PacketCount} packet(s) to {OutputPath} (failed to parse {FailedMainMessageCount} main message(s))",
                            parser.Packets.Count,
                            outputPath,
                            parser.FailedParsingCount
                        );
                    }
                    catch (Exception exception)
                    {
                        Log.Error(exception, "Failed to parse {PcapFilePath}", pcapFilePath);
                    }
                }
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
