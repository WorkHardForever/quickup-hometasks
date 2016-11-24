using Microsoft.EntityFrameworkCore;

namespace Middleware.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        { }

        public DbSet<Client> Clients;
    }
}
