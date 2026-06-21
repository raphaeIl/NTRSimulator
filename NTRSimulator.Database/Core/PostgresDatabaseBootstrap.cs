using Npgsql;

namespace NTRSimulator.Database.Core
{
    public static class PostgresDatabaseBootstrap
    {
        public static void EnsureDatabaseExists(string connectionString)
        {
            var builder = new NpgsqlConnectionStringBuilder(connectionString);
            var databaseName = builder.Database
                ?? throw new InvalidOperationException("Connection string must specify a Database.");

            builder.Database = "postgres";

            using var connection = new NpgsqlConnection(builder.ConnectionString);
            connection.Open();

            using var checkCmd = connection.CreateCommand();
            checkCmd.CommandText = "SELECT 1 FROM pg_database WHERE datname = @name";
            checkCmd.Parameters.AddWithValue("name", databaseName);
            if (checkCmd.ExecuteScalar() is not null)
                return;

            using var createCmd = connection.CreateCommand();
            createCmd.CommandText = $"CREATE DATABASE {QuoteIdentifier(databaseName)}";
            createCmd.ExecuteNonQuery();
        }

        private static string QuoteIdentifier(string identifier) =>
            "\"" + identifier.Replace("\"", "\"\"") + "\"";
    }
}
