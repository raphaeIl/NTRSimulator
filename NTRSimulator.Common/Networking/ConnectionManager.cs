using System.Collections.Concurrent;

namespace NTRSimulator.Common.Networking
{
    public sealed class ConnectionManager
    {
        private readonly ConcurrentDictionary<string, Connection> _connections = new();

        public int Count => _connections.Count;

        public IReadOnlyCollection<Connection> Connections => _connections.Values.ToArray();

        public void Add(Connection connection) => _connections[connection.Id] = connection;

        public void Remove(Connection connection) => _connections.TryRemove(connection.Id, out _);
    }
}
