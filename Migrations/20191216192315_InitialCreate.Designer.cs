﻿// <auto-generated />
using System;
using CRM3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM3.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20191216192315_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRM3.Models.CompanyDetails", b =>
                {
                    b.Property<string>("CompanyName")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("AccountManager")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Comments")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ContactPersonOne")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ContactPersonTwo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("FirstContactDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PersonalEmailOne")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PersonalEmailTwo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PublicEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("SecondContactDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CompanyName");

                    b.ToTable("CompanyDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
