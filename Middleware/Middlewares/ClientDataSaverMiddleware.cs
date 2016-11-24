using Microsoft.AspNetCore.Http;
using Middleware.Models;
using System.Threading.Tasks;

namespace Middleware.Middlewares
{
    public class ClientDataSaverMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ClientContext _database;

        public ClientDataSaverMiddleware(RequestDelegate next, ClientContext database)
        {
            _next = next;
            _database = database;
        }

        public async Task Invoke(HttpContext context)
        {
            var requestClient = context.Request.Headers;

            Client newClient = new Client();

            int referer, ipAddress;
            if (int.TryParse(requestClient["Referer"], out referer) != false &&
                int.TryParse(requestClient["IpAddress"], out ipAddress) != false)
                _database.Clients.Add(new Client
                {
                    IpAddress = ipAddress,
                    Referer = referer
                });

            if (requestClient["Referer"] != string.Empty)
                await _next.Invoke(context);
        }
    }
}
