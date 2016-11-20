using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AspWithEf.Models;

namespace AspWithEf.Migrations
{
    [DbContext(typeof(StudyContext))]
    partial class GroupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-preview1-22509")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspWithEf.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("AspWithEf.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GroupId");

                    b.Property<string>("Name");

                    b.HasKey("StudentId");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AspWithEf.Models.Student", b =>
                {
                    b.HasOne("AspWithEf.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");
                });
        }
    }
}
