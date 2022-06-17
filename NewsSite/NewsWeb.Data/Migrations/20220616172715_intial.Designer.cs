﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsWeb.Data;

#nullable disable

namespace NewsWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220616172715_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NewsWeb.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            Name = "IT"
                        },
                        new
                        {
                            Id = new Guid("a181d36c-c369-4db4-ac35-6ced403c7e4b"),
                            Name = "Global"
                        },
                        new
                        {
                            Id = new Guid("87a51b91-c4da-4f42-a7de-266765a13b10"),
                            Name = "Footbal"
                        });
                });

            modelBuilder.Entity("NewsWeb.Models.Links", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("NewsWeb.Models.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Links")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfViewers")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4dd93f72-fa88-48fa-bc36-0e065eef71a7"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6025),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        },
                        new
                        {
                            Id = new Guid("dd47e1ff-a2ce-450e-bda0-fdd61ac6e0a6"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6042),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        },
                        new
                        {
                            Id = new Guid("df6bf6be-6d65-49c1-9be5-0caabcb7cd3b"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6063),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        },
                        new
                        {
                            Id = new Guid("8b95e8a7-9387-40db-9d53-f0417116a474"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6065),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        },
                        new
                        {
                            Id = new Guid("77963a72-dae5-49d3-9f6b-6945e52a78e8"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6067),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        },
                        new
                        {
                            Id = new Guid("2899fca1-62e9-4763-a5d9-2be5837a0842"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6069),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        },
                        new
                        {
                            Id = new Guid("5da5a8a4-ba2a-4ce1-b3d5-fc112cc35bb4"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6072),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        },
                        new
                        {
                            Id = new Guid("0544054f-e86f-4f18-b44f-913dc1f5e83b"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6074),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        },
                        new
                        {
                            Id = new Guid("f1acd81a-9d32-4a83-bd74-17aeb05cc802"),
                            Body = "❗️Бирор егуликка нисбатан кучли хоҳиш организмда қайсидир модда етишмаслигидан дарак беради.",
                            CategoryId = new Guid("6ff3bb66-b37e-4b73-9472-b8c35a4f5881"),
                            CreatedTime = new DateTime(2022, 6, 16, 22, 27, 14, 949, DateTimeKind.Local).AddTicks(6076),
                            Images = "trending/trending_bottom1.jpg",
                            Links = "",
                            NumberOfViewers = 12,
                            Title = "Today is a good day!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}