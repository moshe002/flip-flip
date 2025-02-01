using Npgsql;

namespace backend.Services
{
    public class DatabaseService
    {
        private readonly NpgsqlConnection _connection;
        private readonly ILogger<DatabaseService> _logger;

        public DatabaseService(NpgsqlConnection connection, ILogger<DatabaseService> logger)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
            _logger = logger;
        }

        public string GetConnectionString()
        {
            _logger.LogInformation("Getting connection string: {ConnectionString}", _connection.ConnectionString);
            return _connection.ConnectionString;
        }
    }
}