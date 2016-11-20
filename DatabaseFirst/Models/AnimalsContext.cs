using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseFirst
{
    public partial class AnimalsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Animals;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bird>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();
            });

            modelBuilder.Entity<Dove>(entity =>
            {
                entity.HasOne(d => d.Bird)
                    .WithMany(p => p.Dove)
                    .HasForeignKey(d => d.BirdId);
            });
        }

        public virtual DbSet<Bird> Bird { get; set; }
        public virtual DbSet<Dove> Dove { get; set; }
    }
}