using System;
using Common.Logging;

namespace CommonLoggingTest
{
    class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger<Program>();

        static void Main(string[] args)
        {
            SetupLogging();
            Logger.Debug("Test logging");
            Console.ReadLine();
        }

        private static void SetupLogging()
        {
            var props = new Common.Logging.Configuration.NameValueCollection
            {
                { "configType", "FILE" },
                { "configFile", "./nlog.config" }
            };

            LogManager.Adapter = new Common.Logging.NLog.NLogLoggerFactoryAdapter(props);
        }
    }

}
