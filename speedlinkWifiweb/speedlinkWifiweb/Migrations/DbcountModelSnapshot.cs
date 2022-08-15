﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using speedlinkWifiweb.Models;

namespace speedlinkWifiweb.Migrations
{
    [DbContext(typeof(Dbcount))]
    partial class DbcountModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("speedlinkWifiweb.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("speedlinkWifiweb.Models.blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("mainName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("underneme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("speedlinkWifiweb.Models.mainpage.About", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("abouts");
                });

            modelBuilder.Entity("speedlinkWifiweb.Models.mainpage.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("speedlinkWifiweb.Models.mainpage.PORTFOLIO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PORTFOLIOs");
                });

            modelBuilder.Entity("speedlinkWifiweb.Models.mainpage.Team", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("faecbook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instgerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("speedlinkWifiweb.Models.mainpage.main", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainImage1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Mains");
                });

            modelBuilder.Entity("speedlinkWifiweb.Models.mainpage.services", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("services");
                });
#pragma warning restore 612, 618
        }
    }
}
