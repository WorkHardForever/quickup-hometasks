using Microsoft.Extensions.Logging;
using System;

namespace LoggerAndFilters.cs.Services.CustomLogger
{
    public class CustomLoggerProvider : ILoggerProvider
    {
        private readonly Func<string, LogLevel, bool> _filter;
        private readonly IFileService _fileService;

        public CustomLoggerProvider(Func<string, LogLevel, bool> filter, IFileService fileService)
        {
            _fileService = fileService;
            _filter = filter;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(categoryName, _filter, _fileService);
        }

        public void Dispose()
        {

        }
    }
}
