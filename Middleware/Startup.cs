using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Middleware.Middlewares;

namespace Middleware
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();

            app.MapWhen(context =>
            {
                return context.Request.Query.ContainsKey("Products");
            }, HandleProducts);
        }

        private void HandleProducts(IApplicationBuilder app)
        {
            app.UseClientDataSaver();
        }
    }
}
