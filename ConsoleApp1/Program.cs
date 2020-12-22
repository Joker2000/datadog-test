namespace ConsoleApp1
{
    using Serilog;
    using Serilog.Sinks.Datadog.Logs;

    public class Program
    {
        public static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.DatadogLogs("<API_KEY>", configuration: new DatadogConfiguration { Url = "https://http-intake.logs.datadoghq.eu" })
                .CreateLogger();

            log.Information("Test");
            log.Error("Test");
        }
    }
}
