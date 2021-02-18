﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SangereanVirgilProiectMedii.Data;

namespace SangereanVirgilProiectMedii.Migrations
{
    [DbContext(typeof(SangereanVirgilProiectMediiContext))]
    [Migration("20210218190523_DataLansarii")]
    partial class DataLansarii
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SangereanVirgilProiectMedii.Models.Film", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataLansarii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PretBilet")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<string>("Titlu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Film");
                });
#pragma warning restore 612, 618
        }
    }
}
