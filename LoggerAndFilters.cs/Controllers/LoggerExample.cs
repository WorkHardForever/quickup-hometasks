using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoggerAndFilters.cs.Controllers
{
    [Route("api/log")]
    public class LoggerExample : Controller
    {
        private ILogger<LoggerExample> _logger;
        private IFileService _fileService;

        public LoggerExample(ILogger<LoggerExample> logger, IFileService fileService)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _fileService.SaveData("");
            _logger.LogInformation("Nice work!");
            return new ObjectResult($"OK!");
        }
    }
}
