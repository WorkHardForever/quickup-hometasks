using AspWithEf.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspWithEf.Migrations
{
    public static class ConnectDatabase
    {
        public static void ConnectDb(this IServiceCollection services)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=University;Trusted_Connection=True;";
            services.AddDbContext<StudyContext>(options => options.UseSqlServer(connection));
        }
    }
}
