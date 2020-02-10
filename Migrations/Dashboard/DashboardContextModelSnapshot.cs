﻿// <auto-generated />
using System;
using CRM3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM3.Migrations.Dashboard
{
    [DbContext(typeof(DashboardContext))]
    partial class DashboardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRM3.Models.Tasks", b =>
                {
                    b.Property<string>("TaskName")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("HighComplexity")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Important")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("TaskName");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
