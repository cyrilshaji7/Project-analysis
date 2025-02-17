﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagementSystem.Data;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250216232925_SeedStudent")]
    partial class SeedStudent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentManagementSystem.Models.ProgramOfStudy", b =>
                {
                    b.Property<string>("ProgramCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgramCode");

                    b.ToTable("Programs");

                    b.HasData(
                        new
                        {
                            ProgramCode = "ARTS",
                            ProgramName = "Arts and Sciences"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GPA")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProgramCode");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1971, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bart",
                            GPA = 2.7000000000000002,
                            LastName = "Simpson",
                            ProgramCode = "ARTS"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1973, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lisa",
                            GPA = 4.0,
                            LastName = "Simpson",
                            ProgramCode = "ARTS"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Models.Student", b =>
                {
                    b.HasOne("StudentManagementSystem.Models.ProgramOfStudy", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");
                });
#pragma warning restore 612, 618
        }
    }
}
