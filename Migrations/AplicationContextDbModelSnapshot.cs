﻿// <auto-generated />
using System;
using CRUDDEMO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDDEMO.Migrations
{
    [DbContext(typeof(AplicationContextDb))]
    partial class AplicationContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("CRUDDEMO.Models.Country", b =>
                {
                    b.Property<int>("c_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("c_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("c_id");

                    b.ToTable("tblCountry");
                });

            modelBuilder.Entity("CRUDDEMO.Models.StateBind", b =>
                {
                    b.Property<int>("state_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Countryc_id")
                        .HasColumnType("int");

                    b.Property<string>("state_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("state_id");

                    b.HasIndex("Countryc_id");

                    b.ToTable("tblState");
                });

            modelBuilder.Entity("CRUDDEMO.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<int>("country")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("standard")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tblStudent");
                });

            modelBuilder.Entity("CRUDDEMO.Models.StateBind", b =>
                {
                    b.HasOne("CRUDDEMO.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("Countryc_id");

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}