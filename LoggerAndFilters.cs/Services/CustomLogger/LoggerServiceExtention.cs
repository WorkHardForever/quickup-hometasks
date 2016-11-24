using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LoggerAndFilters.cs.Services.CustomLogger
{
    public static class LoggerServiceExtention
    {
        public static void AddCustomLogger(this IServiceProvider service)
        {
            service.AddTransient<LoggingMailService>();
        }

        public static ILoggerFactory AddFile(this ILoggerFactory factory,
                                             IMailService mailService,
                                             Func<string, LogLevel, bool> filter = null)
        {
            factory.AddProvider(new CustomLoggerProvider(filter, mailService));
            return factory;
        }
    }
}
