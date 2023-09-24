﻿// <auto-generated />
using MVCApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230924052705_Table_Daily")]
    partial class Table_Daily
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("MVCApp.Models.Daily", b =>
                {
                    b.Property<string>("Madaily")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nguoidaidien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tendaily")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Madaily");

                    b.ToTable("Daily");
                });

            modelBuilder.Entity("MVCApp.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
