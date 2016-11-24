using LoggerAndFilters.CustomFilters.ResultFilter;
using Microsoft.AspNetCore.Mvc;

namespace LoggerAndFilters.Controllers
{
    [Route("api/ex")]
    public class ExampleController : Controller
    {
        [ResponseResultTime("string1", "string2")]
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("Hello World!");
        }
    }
}
