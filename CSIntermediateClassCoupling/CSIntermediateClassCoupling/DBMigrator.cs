namespace CSIntermediateClassCoupling
{
    partial class Program
    {
        public class DBMigrator
        {
            private readonly Logger _logger;
            public DBMigrator(Logger logger)
            {
                _logger = logger;
            }

            public void Migrate()
            {
                _logger.Log("This is some message about migrations and stuff...");
            }
        }
    }
}
