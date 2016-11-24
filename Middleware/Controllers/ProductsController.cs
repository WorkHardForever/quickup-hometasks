using Microsoft.AspNetCore.Mvc;

namespace Middleware.Controllers
{
    [Route("api/ex")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(
                $"Request.Headers: {Request.Headers["IpAddress"]}\n{Request.Headers["Referer"]}");
        }
    }
}
