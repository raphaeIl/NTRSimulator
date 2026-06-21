using Google.Protobuf;

namespace NTRSimulator.Common.Protocol
{
    public static class MsgIdResolver
    {
        private const string TranslationFileName = "fullNameTranslations.txt";
        private static readonly Lazy<Dictionary<string, string>> NameTranslations = new(LoadNameTranslations);

        public static MsgId GetMsgId(ushort rawMsgId)
        {
            return Enum.IsDefined(typeof(MsgId), (int)rawMsgId)
                ? (MsgId)(int)rawMsgId
                : MsgId.MsgNone;
        }

        public static bool TryGetRawMsgId(IMessage message, out ushort rawMsgId)
        {
            if (message is null)
            {
                rawMsgId = 0;
                return false;
            }

            string proto = message.Descriptor.Name; // e.g. CS_Login
            string enumName = proto.StartsWith("CS_", StringComparison.Ordinal)
                ? "MsgCs" + proto[3..]
                : proto.StartsWith("SC_", StringComparison.Ordinal)
                    ? "MsgSc" + proto[3..]
                    : "Msg" + proto;
            if (Enum.TryParse<MsgId>(enumName, out var msgId) && msgId != MsgId.MsgNone)
            {
                rawMsgId = (ushort)msgId;
                return true;
            }
            rawMsgId = 0;
            return false;
        }

        public static string GetProtoName(MsgId msgId)
        {
            string msgName = msgId.ToString();
            if (!msgName.StartsWith("Msg", StringComparison.Ordinal) || msgName.Length <= 3)
            {
                return msgName;
            }

            string trimmed = msgName[3..];
            if (trimmed.StartsWith("Cs", StringComparison.Ordinal) && trimmed.Length > 2)
            {
                return $"CS_{trimmed[2..]}";
            }

            if (trimmed.StartsWith("Sc", StringComparison.Ordinal) && trimmed.Length > 2)
            {
                return $"SC_{trimmed[2..]}";
            }

            return trimmed;
        }

        public static string GetProtoName(ushort rawMsgId)
        {
            return GetProtoName(GetMsgId(rawMsgId));
        }

        public static string? GetTranslatedProtoClassName(MsgId msgId)
        {
            return GetTranslatedProtoClassName(GetProtoName(msgId));
        }

        public static string? GetTranslatedProtoClassName(ushort rawMsgId)
        {
            return GetTranslatedProtoClassName(GetMsgId(rawMsgId));
        }

        public static string? GetTranslatedProtoClassName(string protoName)
        {
            return NameTranslations.Value.GetValueOrDefault(protoName);
        }

        public static bool TryResolve(ushort rawMsgId, out MsgId msgId, out string protoName, out string? translatedProtoClassName)
        {
            msgId = GetMsgId(rawMsgId);
            protoName = GetProtoName(msgId);
            translatedProtoClassName = GetTranslatedProtoClassName(protoName);

            return msgId != MsgId.MsgNone;
        }

        private static Dictionary<string, string> LoadNameTranslations()
        {
            string? path = FindNameTranslationsPath();
            if (path is null)
            {
                return [];
            }

            Dictionary<string, string> translations = [];
            foreach (string line in File.ReadLines(path))
            {
                string trimmedLine = line.Trim();
                if (trimmedLine.Length == 0)
                {
                    continue;
                }

                string[] parts = trimmedLine.Split(',', 2, StringSplitOptions.TrimEntries);
                if (parts.Length != 2)
                {
                    continue;
                }

                string obfuscatedName = parts[0];
                string protoName = parts[1];
                translations.TryAdd(protoName, obfuscatedName);
            }

            return translations;
        }

        private static string? FindNameTranslationsPath()
        {
            string baseDirectory = AppContext.BaseDirectory;
            string[] candidates =
            [
                Path.Combine(baseDirectory, "Resources", TranslationFileName),
                Path.Combine(Environment.CurrentDirectory, "Resources", TranslationFileName),
            ];

            foreach (string candidate in candidates)
            {
                if (File.Exists(candidate))
                {
                    return candidate;
                }
            }

            DirectoryInfo? directory = new(baseDirectory);
            while (directory is not null)
            {
                string candidate = Path.Combine(directory.FullName, "Resources", TranslationFileName);
                if (File.Exists(candidate))
                {
                    return candidate;
                }

                string debugCandidate = Path.Combine(
                    directory.FullName,
                    "NTRSimulator",
                    "bin",
                    "Debug",
                    "net8.0",
                    "Resources",
                    TranslationFileName
                );
                if (File.Exists(debugCandidate))
                {
                    return debugCandidate;
                }

                string releaseCandidate = Path.Combine(
                    directory.FullName,
                    "NTRSimulator",
                    "bin",
                    "Release",
                    "net8.0",
                    "Resources",
                    TranslationFileName
                );
                if (File.Exists(releaseCandidate))
                {
                    return releaseCandidate;
                }

                directory = directory.Parent;
            }

            return null;
        }
    }
}
