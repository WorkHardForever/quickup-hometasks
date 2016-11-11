using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CodeFirst.Models;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(CourseContext))]
    partial class CourseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirst.Models.CourseQuickUp", b =>
                {
                    b.Property<int>("CourseQuickUpId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CleverStudentStudentId");

                    b.HasKey("CourseQuickUpId");

                    b.HasIndex("CleverStudentStudentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CodeFirst.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CodeFirst.Models.CourseQuickUp", b =>
                {
                    b.HasOne("CodeFirst.Models.Student", "CleverStudent")
                        .WithMany()
                        .HasForeignKey("CleverStudentStudentId");
                });
        }
    }
}
