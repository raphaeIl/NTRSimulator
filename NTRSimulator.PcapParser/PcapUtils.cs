using Google.Protobuf;
using NTRSimulator.Common.Protocol;
using NTRSimulator.Common.Utils;
using Serilog;
using System.Reflection;
using System.Runtime.Loader;

namespace NTRSimulator.PcapParser
{
    public static class PcapUtils
    {
        private static PcapParser? parser;
        private static bool resolverInitialized;
        public static List<GfPacket> Packets { get; private set; } = [];

        public static string DefaultPcapPath = Path.Join(StaticConfig.PcapDir, "full_gacha.pcap");

        public static void Load(string pcapFilePath = "", PcapParserMode parserMode = PcapParserMode.Official)
        {
            EnsurePcapAssemblyResolver();
            parser = new PcapParser(parserMode);
            pcapFilePath = ResolvePcapPath(pcapFilePath);

            parser.ParsePackets(pcapFilePath);
            Packets = parser.Packets.ToList();
            LogLoadedPackets(Packets);
        }

        public static GfPacket[] GetRespPacketsForRequest(MsgId requestMsgId)
        {
            EnsurePacketsLoaded();
            GfPacket? matchingPacket = Packets.FirstOrDefault(packet => packet.PacketMsgId == (ushort)requestMsgId);
            if (matchingPacket is null)
            {
                return [];
            }

            int targetSeqId = matchingPacket.SeqId;
            return Packets
                .Where(packet => packet.SeqId == targetSeqId && packet.PacketType == PacketType.RESPONSE)
                .ToArray();
        }

        public static IMessage[] GetRespMessagesForRequest(MsgId requestMsgId)
        {
            return GetRespPacketsForRequest(requestMsgId)
                .Select(packet => packet.Packet)
                .Where(packet => packet is not null)
                .Cast<IMessage>()
                .ToArray();
        }

        public static GfPacket[] GetPacketsWithMsgIdFromPcap(MsgId msgId, PacketType packetType)
        {
            return GetPacketsFromPcap(msgId, packetType);
        }

        public static BasePacket[] GetBasePacketsWithMsgIdFromPcap(MsgId msgId, PacketType packetType)
        {
            return GetPacketsFromPcap(msgId, packetType)
                .Select(packet => packet.ToBasePacket())
                .ToArray();
        }

        // get all packets of id/type
        public static GfPacket[] GetPacketsFromPcap(MsgId msgId, PacketType packetType)
        {
            EnsurePacketsLoaded();
            return Packets
                .Where(packet => packet.PacketType == packetType && packet.PacketMsgId == (ushort)msgId)
                .ToArray();
        }

        public static IMessage[] GetMessagesFromPcap(MsgId msgId, PacketType packetType)
        {
            return GetPacketsFromPcap(msgId, packetType)
                .Select(packet => packet.Packet)
                .Where(packet => packet is not null)
                .Cast<IMessage>()
                .ToArray();
        }

        // get the first packet of id/type
        public static T? GetPacketFromPcap<T>(MsgId msgId, PacketType packetType) where T : class, IMessage
        {
            return GetMessagesFromPcap(msgId, packetType).OfType<T>().FirstOrDefault();
        }

        private static PcapParser GetParser()
        {
            if (parser is null)
            {
                Load();
            }

            return parser ?? throw new InvalidOperationException("Pcap parser failed to load.");
        }

        private static void EnsurePacketsLoaded()
        {
            PcapParser loadedParser = GetParser();
            if (Packets.Count == 0 && loadedParser.Packets.Count > 0)
            {
                Packets = loadedParser.Packets.ToList();
            }
        }

        private static void LogLoadedPackets(IReadOnlyList<GfPacket> packets)
        {
            for (int i = 0; i < packets.Count; i++)
            {
                GfPacket packet = packets[i];
                Log.Information(
                    "Loaded packet {PacketIndex}/{PacketCount}: {PacketType} {PacketName} ({PacketMsgId}) SeqId={SeqId} Length={PacketLength} IsEncrypted={MainMessageIsEncrypted} EncryptedByte={MainMessageEncryptedByte}",
                    i + 1,
                    packets.Count,
                    packet.PacketType,
                    packet.PacketName,
                    packet.PacketMsgId,
                    packet.SeqId,
                    packet.PacketLength,
                    packet.MainMessageIsEncrypted,
                    packet.MainMessageEncryptedByte
                );
            }
        }

        private static void EnsurePcapAssemblyResolver()
        {
            if (resolverInitialized)
            {
                return;
            }

            AssemblyLoadContext.Default.Resolving += ResolvePcapAssembly;
            AppDomain.CurrentDomain.AssemblyResolve += ResolvePcapAssemblyFromAppDomain;
            resolverInitialized = true;
        }

        private static Assembly? ResolvePcapAssembly(AssemblyLoadContext context, AssemblyName assemblyName)
        {
            if (!assemblyName.Name?.StartsWith("PcapDotNet.", StringComparison.OrdinalIgnoreCase) ?? true)
            {
                return null;
            }

            Assembly? alreadyLoaded = FindLoadedPcapAssembly(assemblyName.Name);
            if (alreadyLoaded is not null)
            {
                return alreadyLoaded;
            }

            string fileName = $"{assemblyName.Name}.dll";
            string[] searchDirectories =
            [
                AppContext.BaseDirectory,
                Path.GetDirectoryName(typeof(PcapUtils).Assembly.Location) ?? string.Empty,
                Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location ?? string.Empty) ?? string.Empty
            ];

            foreach (string directory in searchDirectories.Where(dir => !string.IsNullOrWhiteSpace(dir)))
            {
                string candidatePath = Path.Combine(directory, fileName);
                if (File.Exists(candidatePath))
                {
                    try
                    {
                        return context.LoadFromAssemblyPath(candidatePath);
                    }
                    catch (FileLoadException)
                    {
                        // The assembly may already be loaded with a different version.
                        return FindLoadedPcapAssembly(assemblyName.Name);
                    }
                }
            }

            return null;
        }

        private static Assembly? ResolvePcapAssemblyFromAppDomain(object? sender, ResolveEventArgs args)
        {
            return ResolvePcapAssembly(AssemblyLoadContext.Default, new AssemblyName(args.Name));
        }

        private static Assembly? FindLoadedPcapAssembly(string? assemblySimpleName)
        {
            if (string.IsNullOrWhiteSpace(assemblySimpleName))
            {
                return null;
            }

            return AppDomain.CurrentDomain
                .GetAssemblies()
                .FirstOrDefault(assembly =>
                    string.Equals(assembly.GetName().Name, assemblySimpleName, StringComparison.OrdinalIgnoreCase)
                );
        }

        private static string ResolvePcapPath(string requestedPath)
        {
            if (!string.IsNullOrWhiteSpace(requestedPath))
            {
                if (File.Exists(requestedPath))
                {
                    return requestedPath;
                }

                throw new FileNotFoundException($"Requested pcap file does not exist: {requestedPath}", requestedPath);
            }

            if (File.Exists(DefaultPcapPath))
            {
                return DefaultPcapPath;
            }

            if (Directory.Exists(StaticConfig.PcapDir))
            {
                string? firstPcap = Directory
                    .EnumerateFiles(StaticConfig.PcapDir, "*.pcap", SearchOption.TopDirectoryOnly)
                    .OrderBy(path => path, StringComparer.OrdinalIgnoreCase)
                    .FirstOrDefault();

                if (firstPcap is not null)
                {
                    Log.Warning(
                        "Default pcap file not found at {DefaultPcapPath}. Falling back to first available pcap: {FallbackPcapPath}",
                        DefaultPcapPath,
                        firstPcap
                    );
                    return firstPcap;
                }
            }

            throw new FileNotFoundException(
                $"No pcap file found. Default expected path: {DefaultPcapPath}. Pcap directory: {StaticConfig.PcapDir}"
            );
        }
    }
}
