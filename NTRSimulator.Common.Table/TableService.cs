using System.Collections.Concurrent;
using System.Reflection;
using Google.Protobuf;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace NTRSimulator.Common.Table
{
    public sealed class TableService(ILogger<TableService> logger) : ITableService
    {
        private const int RowFieldNumber = 1;
        private const uint RowFieldTag = (RowFieldNumber << 3) | (uint)WireFormat.WireType.LengthDelimited;

        private readonly ConcurrentDictionary<Type, object> caches = new();
        private readonly ConcurrentDictionary<Type, MessageParser> parserCache = new();

        public static string ResourceDir = Path.Join(Path.GetDirectoryName(AppContext.BaseDirectory), "Resources");

        public void DumpAllJsonToFile(string? outputDir = null)
        {
            var tablesDir = Path.Combine(ResourceDir, "Tables");
            if (!Directory.Exists(tablesDir))
                throw new DirectoryNotFoundException($"Tables directory not found: {tablesDir}");

            outputDir ??= Path.Combine(ResourceDir, "Dump");
            Directory.CreateDirectory(outputDir);

            var getTableMethod = typeof(TableService).GetMethod(nameof(GetTable), BindingFlags.Public | BindingFlags.Instance)!;
            var assembly = GetTableAssembly();

            foreach (var filePath in Directory.EnumerateFiles(tablesDir, "*.bytes"))
            {
                var tableName = Path.GetFileNameWithoutExtension(filePath);
                var type = assembly.GetType($"NTRSimulator.Common.Table.{tableName}");
                if (type is null)
                {
                    logger.LogWarning("Skipping {Table}: no matching protobuf type", tableName);
                    continue;
                }

                try
                {
                    var rows = getTableMethod.MakeGenericMethod(type).Invoke(this, [false])!;
                    var json = JsonConvert.SerializeObject(rows, Formatting.Indented);
                    var outputPath = Path.Combine(outputDir, $"{tableName}.json");
                    File.WriteAllText(outputPath, json);
                    logger.LogInformation("Dumped {Table} to {Path}", tableName, outputPath);
                }
                catch (Exception ex)
                {
                    var actual = (ex as TargetInvocationException)?.InnerException ?? ex;
                    logger.LogWarning(actual, "Failed to dump {Table}", tableName);
                }
            }
        }

        public List<T> GetTable<T>(bool bypassCache = false) where T : IMessage<T>, new()
        {
            var type = typeof(T);

            if (!bypassCache && caches.TryGetValue(type, out var cached))
                return (List<T>)cached;

            var bytesFilePath = GetBytesFilePath(type.Name);

            if (!File.Exists(bytesFilePath))
                throw new FileNotFoundException(
                    $"Table file not found: {bytesFilePath}", bytesFilePath);

            var rows = LoadTable<T>(bytesFilePath);
            caches[type] = rows;

            logger.LogDebug("{Table} loaded {Count} row(s) and cached", type.Name, rows.Count);
            return rows;
        }

        // TODO: idk whats the url to download these
        //public void DownloadTable<T>(string url, bool autoLoad = true) where T : IMessage<T>, new()
        //{
        //    var outputPath = GetBytesFilePath(typeof(T).Name);
        //    Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);

        //    using var client = new HttpClient();
        //    var bytes = client.GetByteArrayAsync(url).GetAwaiter().GetResult();

        //    File.WriteAllBytes(outputPath, bytes);
        //    logger.LogInformation("Downloaded {Table} ({Bytes} bytes) from {Url}",
        //        typeof(T).Name, bytes.Length, url);

        //    if (autoLoad)
        //        GetTable<T>(bypassCache: true);
        //}

        public void ClearCache()
        {
            var count = caches.Count;
            caches.Clear();
            logger.LogInformation("Table cache cleared ({Count} entries evicted)", count);
        }

        private static string GetBytesFilePath(string tableName)
        {
            return Path.Combine(ResourceDir, "Tables", $"{tableName}.bytes");
        }

        private static Assembly GetTableAssembly()
        {
            const string assemblyName = "NTRSimulator.Common.Proto";

            var loaded = AppDomain.CurrentDomain
                .GetAssemblies()
                .FirstOrDefault(a => string.Equals(a.GetName().Name, assemblyName, StringComparison.Ordinal));
            if (loaded is not null)
                return loaded;

            return Assembly.Load(new AssemblyName(assemblyName));
        }

        /// <summary>
        /// Reads a <c>.bytes</c> file using the client binary format:
        /// <code>
        /// [0..3]       4-byte LE uint32: header/index protobuf size (N)
        /// [4..4+N-1]   Header/index protobuf (used by client for lazy row loading via StcTableDataMap)
        /// [4+N..]      Wrapper protobuf: repeated row messages at field 1
        /// </code>
        /// The server skips the header/index and eagerly parses every row in field 1.
        /// </summary>
        private List<T> LoadTable<T>(string filePath) where T : IMessage<T>, new()
        {
            var fileBytes = File.ReadAllBytes(filePath);

            if (fileBytes.Length < 4)
                throw new InvalidDataException(
                    $"Table file is too small ({fileBytes.Length} bytes): {filePath}");

            int headerSize = (int)BitConverter.ToUInt32(fileBytes, 0);
            int dataOffset = 4 + headerSize;

            if (dataOffset > fileBytes.Length)
                throw new InvalidDataException(
                    $"Table header declares {headerSize} bytes but file is only " +
                    $"{fileBytes.Length} bytes: {filePath}");

            int dataSize = fileBytes.Length - dataOffset;

            logger.LogDebug(
                "{Table}: file={FileSize} bytes, header={HeaderSize}, data={DataSize} (offset {Offset})",
                typeof(T).Name, fileBytes.Length, headerSize, dataSize, dataOffset);

            var parser = GetParser<T>();
            var rows = new List<T>();

            using var input = new CodedInputStream(fileBytes, dataOffset, dataSize);
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if (tag == RowFieldTag)
                {
                    try
                    {
                        rows.Add((T)parser.ParseFrom(input.ReadBytes()));
                    }
                    catch (Exception ex)
                    {
                        logger.LogWarning(ex, "Failed to parse a row in {Table}, skipping", typeof(T).Name);
                        break;
                    }

                    continue;
                }

                input.SkipLastField();
            }

            return rows;
        }

        private MessageParser GetParser<T>() where T : IMessage<T>, new()
        {
            return parserCache.GetOrAdd(typeof(T), static type =>
            {
                var parserProp = type.GetProperty("Parser",
                    BindingFlags.Static | BindingFlags.Public)
                    ?? throw new InvalidOperationException(
                        $"Type {type.FullName} does not have a static Parser property. " +
                        $"Is it a protobuf-generated IMessage type?");

                return (MessageParser)parserProp.GetValue(null)!;
            });
        }
    }

    public interface ITableService
    {
        List<T> GetTable<T>(bool bypassCache = false) where T : IMessage<T>, new();

        void DumpAllJsonToFile(string? outputDir = null);

        //void DownloadTable<T>(string url, bool autoLoad = true) where T : IMessage<T>, new();
        
        void ClearCache();
    }
}
