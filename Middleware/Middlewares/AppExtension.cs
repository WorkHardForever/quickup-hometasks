using Microsoft.AspNetCore.Builder;

namespace Middleware.Middlewares
{
    public static class AppExtension
    {
        public static IApplicationBuilder UseClientDataSaver(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ClientDataSaverMiddleware>();
        }
    }
}
