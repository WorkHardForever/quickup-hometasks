using Microsoft.EntityFrameworkCore;

namespace LoggerAndFilters.Models.GenericResultTime
{
    public class ResultTimeContext : DbContext
    {
        public ResultTimeContext(DbContextOptions<ResultTimeContext> options)
            : base(options)
        { }

        public DbSet<ResultTime<string>> ResultTimes;
    }
}
