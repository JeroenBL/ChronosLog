using Serilog;
using Serilog.Events;

namespace ChronosLog.Services
{
    public class SeriLogInitializationService
    {
        public SeriLogInitializationService()
        {
            InitializeLogger();
        }

        public void InitializeLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Verbose()
                .CreateLogger();
        }

        public void WriteMessage(LogEventLevel logLevel, string message)
        {
            switch (logLevel)
            {
                case LogEventLevel.Verbose:
                    Log.Verbose(message);
                    break;
                case LogEventLevel.Debug:
                    Log.Debug(message);
                    break;
                case LogEventLevel.Information:
                    Log.Information(message);
                    break;
                case LogEventLevel.Warning:
                    Log.Warning(message);
                    break;
                case LogEventLevel.Error:
                    Log.Error(message);
                    break;
                case LogEventLevel.Fatal:
                    Log.Fatal(message);
                    break;
                default:
                    break;
            }
        }
    }
}
