using DotNetEnv;

namespace Configuration
{
    public static class AppConfiguration
    {
        static AppConfiguration()
        {
            Env.Load();
        }

        public static string ConnectionString => 
            Environment.GetEnvironmentVariable("SERVICE_BUS_CONNECTION_STRING") 
            ?? throw new InvalidOperationException("SERVICE_BUS_CONNECTION_STRING environment variable is not set");

        public static string QueueName => 
            Environment.GetEnvironmentVariable("SERVICE_BUS_QUEUE_NAME") 
            ?? throw new InvalidOperationException("SERVICE_BUS_QUEUE_NAME environment variable is not set");

        public static void ValidateConfiguration()
        {
            try
            {
                _ = ConnectionString;
                _ = QueueName;
                Console.WriteLine("✓ Configuration validation passed");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"✗ Configuration validation failed: {ex.Message}");
                throw;
            }
        }
    }
}