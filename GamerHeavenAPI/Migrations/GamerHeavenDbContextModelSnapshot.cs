﻿// <auto-generated />
using System;
using GamerHeavenAPI.Models.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GamerHeavenAPI.Migrations
{
    [DbContext(typeof(GamerHeavenDbContext))]
    partial class GamerHeavenDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GamerHeavenAPI.Models.Console", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InternalMemory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Consoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 499,
                            Brand = "Sony",
                            Category = "Consoles",
                            Description = "The PlayStation 5 is Sony's latest gaming console.",
                            Img = "ps5_front.jpg",
                            InternalMemory = "825GB SSD",
                            Name = "PlayStation 5",
                            Processor = "AMD Ryzen Zen 2",
                            Ram = "16GB GDDR6",
                            ReleaseDate = "2020-11-12"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 499,
                            Brand = "Microsoft",
                            Category = "Consoles",
                            Description = "The Xbox Series X delivers next-gen gaming experiences.",
                            Img = "xbox_series_x_front.jpg",
                            InternalMemory = "1TB SSD",
                            Name = "Xbox Series X",
                            Processor = "AMD Zen 2",
                            Ram = "16GB GDDR6",
                            ReleaseDate = "2020-11-10"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 299,
                            Brand = "Nintendo",
                            Category = "Consoles",
                            Description = "The Nintendo Switch is a hybrid gaming console.",
                            Img = "nintendo_switch_front.jpg",
                            InternalMemory = "32GB",
                            Name = "Nintendo Switch",
                            Processor = "NVIDIA Custom Tegra",
                            Ram = "4GB",
                            ReleaseDate = "2017-03-03"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 399,
                            Brand = "Microsoft",
                            Category = "Consoles",
                            Description = "The Xbox One X offers enhanced graphics and performance.",
                            Img = "xbox_one_x_front.jpg",
                            InternalMemory = "1TB HDD",
                            Name = "Xbox One X",
                            Processor = "AMD Jaguar",
                            Ram = "12GB GDDR5",
                            ReleaseDate = "2017-11-07"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 399,
                            Brand = "Sony",
                            Category = "Consoles",
                            Description = "The PlayStation 4 Pro offers enhanced graphics and 4K gaming.",
                            Img = "ps4_pro_front.jpg",
                            InternalMemory = "1TB HDD",
                            Name = "PlayStation 4 Pro",
                            Processor = "AMD Jaguar",
                            Ram = "8GB GDDR5",
                            ReleaseDate = "2016-11-10"
                        });
                });

            modelBuilder.Entity("GamerHeavenAPI.Models.Controller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsoleId")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsoleId");

                    b.ToTable("Controllers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 8,
                            Category = "Controllers",
                            ConsoleId = 1,
                            Manufacturer = "Sony",
                            Name = "DualSense Wireless Controller",
                            Platform = "PlayStation 5",
                            ReleaseDate = "2020-11-12"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 10,
                            Category = "Controllers",
                            ConsoleId = 2,
                            Manufacturer = "Microsoft",
                            Name = "Xbox Wireless Controller",
                            Platform = "Xbox Series X",
                            ReleaseDate = "2020-11-10"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 7,
                            Category = "Controllers",
                            ConsoleId = 3,
                            Manufacturer = "Nintendo",
                            Name = "Joy-Con Controllers",
                            Platform = "Nintendo Switch",
                            ReleaseDate = "2017-03-03"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 13,
                            Category = "Controllers",
                            ConsoleId = 4,
                            Manufacturer = "Microsoft",
                            Name = "Xbox Wireless Controller",
                            Platform = "Xbox One X",
                            ReleaseDate = "2017-11-07"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 6,
                            Category = "Controllers",
                            ConsoleId = 5,
                            Manufacturer = "Sony",
                            Name = "DualShock 4 Wireless Controller",
                            Platform = "PlayStation 4 Pro",
                            ReleaseDate = "2016-11-10"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 9,
                            Category = "Controllers",
                            ConsoleId = 3,
                            Manufacturer = "Nintendo",
                            Name = "Pro Controller",
                            Platform = "Nintendo Switch",
                            ReleaseDate = "2017-03-03"
                        },
                        new
                        {
                            Id = 7,
                            Amount = 11,
                            Category = "Controllers",
                            ConsoleId = 2,
                            Manufacturer = "Microsoft",
                            Name = "Xbox Elite Wireless Controller Series 2",
                            Platform = "Xbox Series X",
                            ReleaseDate = "2019-11-04"
                        });
                });

            modelBuilder.Entity("GamerHeavenAPI.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgeOfAdmission")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsoleId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsoleId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgeOfAdmission = 18,
                            Amount = 29,
                            Category = "Games",
                            ConsoleId = 1,
                            Description = "A captivating open-world RPG with epic storytelling.",
                            Img = "witcher3.jpg",
                            Name = "The Witcher 3: Wild Hunt",
                            Publisher = "CD Projekt",
                            ReleaseDate = "2015-05-19"
                        },
                        new
                        {
                            Id = 2,
                            AgeOfAdmission = 17,
                            Amount = 39,
                            Category = "Games",
                            ConsoleId = 2,
                            Description = "An immersive western-themed action-adventure game.",
                            Img = "red_dead_redemption2.jpg",
                            Name = "Red Dead Redemption 2",
                            Publisher = "Rockstar Games",
                            ReleaseDate = "2018-10-26"
                        },
                        new
                        {
                            Id = 3,
                            AgeOfAdmission = 10,
                            Amount = 49,
                            Category = "Games",
                            ConsoleId = 3,
                            Description = "An iconic action-adventure game set in a vast open world.",
                            Img = "breath_of_the_wild.jpg",
                            Name = "The Legend of Zelda: Breath of the Wild",
                            Publisher = "Nintendo",
                            ReleaseDate = "2017-03-03"
                        },
                        new
                        {
                            Id = 4,
                            AgeOfAdmission = 18,
                            Amount = 49,
                            Category = "Games",
                            ConsoleId = 1,
                            Description = "An open-world RPG set in a dystopian future.",
                            Img = "cyberpunk2077.jpg",
                            Name = "Cyberpunk 2077",
                            Publisher = "CD Projekt",
                            ReleaseDate = "2020-12-10"
                        },
                        new
                        {
                            Id = 5,
                            AgeOfAdmission = 18,
                            Amount = 19,
                            Category = "Games",
                            ConsoleId = 2,
                            Description = "An action-packed game in an open-world setting.",
                            Img = "gta5.jpg",
                            Name = "Grand Theft Auto V",
                            Publisher = "Rockstar Games",
                            ReleaseDate = "2013-09-17"
                        },
                        new
                        {
                            Id = 6,
                            AgeOfAdmission = 6,
                            Amount = 39,
                            Category = "Games",
                            ConsoleId = 3,
                            Description = "A platformer adventure featuring the beloved Mario.",
                            Img = "super_mario_odyssey.jpg",
                            Name = "Super Mario Odyssey",
                            Publisher = "Nintendo",
                            ReleaseDate = "2017-10-27"
                        },
                        new
                        {
                            Id = 7,
                            AgeOfAdmission = 17,
                            Amount = 59,
                            Category = "Games",
                            ConsoleId = 2,
                            Description = "A next-gen shooter in the Halo franchise.",
                            Img = "halo_infinite.jpg",
                            Name = "Halo Infinite",
                            Publisher = "Microsoft",
                            ReleaseDate = "2021-12-08"
                        },
                        new
                        {
                            Id = 8,
                            AgeOfAdmission = 18,
                            Amount = 49,
                            Category = "Games",
                            ConsoleId = 1,
                            Description = "A gripping action-adventure game with emotional storytelling.",
                            Img = "the_last_of_us_part_ii.jpg",
                            Name = "The Last of Us Part II",
                            Publisher = "Sony",
                            ReleaseDate = "2020-06-19"
                        },
                        new
                        {
                            Id = 9,
                            AgeOfAdmission = 7,
                            Amount = 29,
                            Category = "Games",
                            ConsoleId = 3,
                            Description = "A sandbox game where you build and explore.",
                            Img = "minecraft.jpg",
                            Name = "Minecraft",
                            Publisher = "Mojang",
                            ReleaseDate = "2011-11-18"
                        },
                        new
                        {
                            Id = 10,
                            AgeOfAdmission = 18,
                            Amount = 0,
                            Category = "Games",
                            ConsoleId = 2,
                            Description = "A battle royale shooter in the Call of Duty universe.",
                            Img = "warzone.jpg",
                            Name = "Call of Duty: Warzone",
                            Publisher = "Activision",
                            ReleaseDate = "2020-03-10"
                        },
                        new
                        {
                            Id = 11,
                            AgeOfAdmission = 18,
                            Amount = 39,
                            Category = "Games",
                            ConsoleId = 1,
                            Description = "An action RPG set in the Viking Age.",
                            Img = "assassins_creed_valhalla.jpg",
                            Name = "Assassin's Creed Valhalla",
                            Publisher = "Ubisoft",
                            ReleaseDate = "2020-11-10"
                        },
                        new
                        {
                            Id = 12,
                            AgeOfAdmission = 3,
                            Amount = 49,
                            Category = "Games",
                            ConsoleId = 3,
                            Description = "A life simulation game with a relaxing island setting.",
                            Img = "animal_crossing_new_horizons.jpg",
                            Name = "Animal Crossing: New Horizons",
                            Publisher = "Nintendo",
                            ReleaseDate = "2020-03-20"
                        },
                        new
                        {
                            Id = 13,
                            AgeOfAdmission = 16,
                            Amount = 0,
                            Category = "Games",
                            ConsoleId = 2,
                            Description = "An online multiplayer shooter with RPG elements.",
                            Img = "destiny_2.jpg",
                            Name = "Destiny 2",
                            Publisher = "Bungie",
                            ReleaseDate = "2017-09-06"
                        },
                        new
                        {
                            Id = 14,
                            AgeOfAdmission = 16,
                            Amount = 29,
                            Category = "Games",
                            ConsoleId = 1,
                            Description = "A superhero action-adventure game featuring Spider-Man.",
                            Img = "spider_man.jpg",
                            Name = "Marvel's Spider-Man",
                            Publisher = "Sony",
                            ReleaseDate = "2018-09-07"
                        },
                        new
                        {
                            Id = 15,
                            AgeOfAdmission = 12,
                            Amount = 49,
                            Category = "Games",
                            ConsoleId = 1,
                            Description = "A modern reimagining of the classic RPG, Final Fantasy VII.",
                            Img = "ffvii_remake.jpg",
                            Name = "Final Fantasy VII Remake",
                            Publisher = "Square Enix",
                            ReleaseDate = "2020-04-10"
                        });
                });

            modelBuilder.Entity("GamerHeavenAPI.Models.TransactionBase", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("GamerHeavenAPI.Models.Controller", b =>
                {
                    b.HasOne("GamerHeavenAPI.Models.Console", "Console")
                        .WithMany("Controllers")
                        .HasForeignKey("ConsoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Console");
                });

            modelBuilder.Entity("GamerHeavenAPI.Models.Game", b =>
                {
                    b.HasOne("GamerHeavenAPI.Models.Console", "Console")
                        .WithMany()
                        .HasForeignKey("ConsoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Console");
                });

            modelBuilder.Entity("GamerHeavenAPI.Models.Console", b =>
                {
                    b.Navigation("Controllers");
                });
#pragma warning restore 612, 618
        }
    }
}
