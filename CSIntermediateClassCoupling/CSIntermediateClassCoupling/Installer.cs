namespace CSIntermediateClassCoupling
{
    partial class Program
    {
        public class Installer
        {
            private readonly Logger _logger;

            public Installer (Logger logger)
            {
                _logger = logger;
            }

            public void Install()
            {
                _logger.Log("Installing program or files or whatever...");

            }
        }
    }
}
