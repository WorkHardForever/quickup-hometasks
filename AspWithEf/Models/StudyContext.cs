using Microsoft.EntityFrameworkCore;

namespace AspWithEf.Models
{
    public class StudyContext : DbContext
    {
        public StudyContext(DbContextOptions<StudyContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
