using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LoggerAndFilters.cs
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomLogger();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
