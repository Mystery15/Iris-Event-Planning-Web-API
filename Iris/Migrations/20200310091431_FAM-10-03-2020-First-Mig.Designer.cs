﻿// <auto-generated />
using Iris.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Iris.Migrations
{
    [DbContext(typeof(ClientDBContext))]
    [Migration("20200310091431_FAM-10-03-2020-First-Mig")]
    partial class FAM10032020FirstMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Iris.Models.DClient", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Userpass")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClientID");

                    b.ToTable("DClients");
                });
#pragma warning restore 612, 618
        }
    }
}
