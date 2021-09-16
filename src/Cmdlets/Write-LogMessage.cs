using ChronosLog.Services;
using Serilog.Events;
using System.Management.Automation;

namespace ChronosLog.Cmdlets
{
    [Cmdlet(VerbsCommunications.Write, "LogMessage")]
    public class Write_LogMessage : PSCmdlet
    {
        private SeriLogInitializationService _seriLogInitializationService;

        public Write_LogMessage()
        {
            _seriLogInitializationService = new SeriLogInitializationService();
        }

        [Parameter(Mandatory = true)]
        public string Message { get; set; }

        [Parameter(Mandatory = true)]
        public LogEventLevel LogLevel { get; set; }

        protected override void ProcessRecord()
        {
            _seriLogInitializationService.WriteMessage(LogLevel, Message);
        }
    }
}
