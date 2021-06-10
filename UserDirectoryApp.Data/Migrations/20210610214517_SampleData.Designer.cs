﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserDirectoryApp.Data;

namespace UserDirectoryApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210610214517_SampleData")]
    partial class SampleData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserDirectoryApp.Core.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fc066eb7-5bf7-d32d-dc32-1282260ffe25"),
                            BirthDate = new DateTime(2020, 8, 29, 1, 28, 13, 37, DateTimeKind.Local).AddTicks(8163),
                            Email = "Vicente_Wintheiser31@yahoo.com",
                            Location = "West Albertburgh",
                            Name = "Vicente",
                            Surname = "Wintheiser"
                        },
                        new
                        {
                            Id = new Guid("d8256cd7-8125-1c78-2f9c-64e83199fef0"),
                            BirthDate = new DateTime(2020, 9, 7, 13, 26, 51, 366, DateTimeKind.Local).AddTicks(890),
                            Email = "Benedict_Hudson@hotmail.com",
                            Location = "East Camden",
                            Name = "Benedict",
                            Surname = "Hudson"
                        },
                        new
                        {
                            Id = new Guid("47e466ed-2615-ad41-8156-66b659ec00ae"),
                            BirthDate = new DateTime(2020, 12, 10, 15, 23, 50, 17, DateTimeKind.Local).AddTicks(9410),
                            Email = "Mina41@hotmail.com",
                            Location = "Bodeport",
                            Name = "Mina",
                            Surname = "Hoeger"
                        },
                        new
                        {
                            Id = new Guid("f2b94b92-660e-99b9-3c38-1b93d4197523"),
                            BirthDate = new DateTime(2020, 11, 15, 14, 56, 5, 242, DateTimeKind.Local).AddTicks(6398),
                            Email = "Jewell.Gusikowski86@hotmail.com",
                            Location = "Juddburgh",
                            Name = "Jewell",
                            Surname = "Gusikowski"
                        },
                        new
                        {
                            Id = new Guid("6a8c29a1-694b-c949-82da-88ba73efad1c"),
                            BirthDate = new DateTime(2020, 7, 3, 12, 44, 56, 22, DateTimeKind.Local).AddTicks(6044),
                            Email = "Helen.Pagac@gmail.com",
                            Location = "Port Teresa",
                            Name = "Helen",
                            Surname = "Pagac"
                        },
                        new
                        {
                            Id = new Guid("4403b9f1-a425-48b8-36c5-900dd2ecb149"),
                            BirthDate = new DateTime(2021, 5, 19, 14, 49, 1, 172, DateTimeKind.Local).AddTicks(3413),
                            Email = "Ahmed88@yahoo.com",
                            Location = "Lebsackstad",
                            Name = "Ahmed",
                            Surname = "Langworth"
                        },
                        new
                        {
                            Id = new Guid("8f1bf250-ebb8-af15-745a-af46855d36cf"),
                            BirthDate = new DateTime(2021, 2, 8, 3, 36, 49, 428, DateTimeKind.Local).AddTicks(7174),
                            Email = "Michaela13@yahoo.com",
                            Location = "East Lorenzoborough",
                            Name = "Michaela",
                            Surname = "Donnelly"
                        },
                        new
                        {
                            Id = new Guid("7541791f-65b4-2618-d5b1-9db97dda7a5e"),
                            BirthDate = new DateTime(2021, 1, 19, 11, 53, 44, 426, DateTimeKind.Local).AddTicks(3488),
                            Email = "Donato_Dickinson@hotmail.com",
                            Location = "Amyaville",
                            Name = "Donato",
                            Surname = "Dickinson"
                        },
                        new
                        {
                            Id = new Guid("0ecd2bff-2a06-bee8-a4cc-9b6dffa64a2d"),
                            BirthDate = new DateTime(2021, 5, 10, 21, 35, 1, 520, DateTimeKind.Local).AddTicks(1635),
                            Email = "Luella_Ruecker@yahoo.com",
                            Location = "Donnystad",
                            Name = "Luella",
                            Surname = "Ruecker"
                        },
                        new
                        {
                            Id = new Guid("cd3035ed-e68e-7516-65b4-394b18cf86b5"),
                            BirthDate = new DateTime(2020, 12, 13, 22, 26, 41, 359, DateTimeKind.Local).AddTicks(7663),
                            Email = "Judah25@gmail.com",
                            Location = "Millstown",
                            Name = "Judah",
                            Surname = "Lang"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
