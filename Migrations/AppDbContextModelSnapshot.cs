﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskProject.Data;

#nullable disable

namespace TaskProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TaskProject.Models.EducationDetails", b =>
                {
                    b.Property<int>("EducationDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameOfInstitute")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PersonalDetailsId")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfDegree")
                        .HasColumnType("int");

                    b.Property<DateOnly>("YearOfPassing")
                        .HasColumnType("date");

                    b.HasKey("EducationDetailsId");

                    b.HasIndex("PersonalDetailsId");

                    b.ToTable("EducationDetails");
                });

            modelBuilder.Entity("TaskProject.Models.PersonalDetails", b =>
                {
                    b.Property<int>("PersonalDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte>("AgeInYears")
                        .HasColumnType("tinyint unsigned");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PersonalDetailsId");

                    b.ToTable("PersonalDetails");
                });

            modelBuilder.Entity("TaskProject.Models.EducationDetails", b =>
                {
                    b.HasOne("TaskProject.Models.PersonalDetails", "PersonalDetails")
                        .WithMany()
                        .HasForeignKey("PersonalDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
