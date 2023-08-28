using Microsoft.EntityFrameworkCore;

namespace GamerHeavenAPI.Models.DbContexts
{
    public class GamerHeavenDbContext : DbContext
    {
        public GamerHeavenDbContext(DbContextOptions<GamerHeavenDbContext> options) : base(options) { }

        public DbSet<Console> Consoles { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Controller> Controllers { get; set; }
        public DbSet<TransactionBase> Transactions { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Console>().HasData(
            new Console
            {
                Id = 1,
                Name = "PlayStation 5",
                Brand = "Sony",
                ReleaseDate = "2020-11-12",
                Processor = "AMD Ryzen Zen 2",
                InternalMemory = "825GB SSD",
                Ram = "16GB GDDR6",
                Img = "ps5_front.jpg",
                Description = "The PlayStation 5 is Sony's latest gaming console.",
                Amount = 499
            },

            // Console 2: Xbox Series X
            new Console
            {
                Id = 2,
                Name = "Xbox Series X",
                Brand = "Microsoft",
                ReleaseDate = "2020-11-10",
                Processor = "AMD Zen 2",
                InternalMemory = "1TB SSD",
                Ram = "16GB GDDR6",
                Img = "xbox_series_x_front.jpg",
                Description = "The Xbox Series X delivers next-gen gaming experiences.",
                Amount = 499
            },

            // Console 3: Nintendo Switch
            new Console
            {
                Id = 3,
                Name = "Nintendo Switch",
                Brand = "Nintendo",
                ReleaseDate = "2017-03-03",
                Processor = "NVIDIA Custom Tegra",
                InternalMemory = "32GB",
                Ram = "4GB",
                Img = "nintendo_switch_front.jpg",
                Description = "The Nintendo Switch is a hybrid gaming console.",
                Amount = 299
            },

            // Console 4: Xbox One X
            new Console
            {
                Id = 4,
                Name = "Xbox One X",
                Brand = "Microsoft",
                ReleaseDate = "2017-11-07",
                Processor = "AMD Jaguar",
                InternalMemory = "1TB HDD",
                Ram = "12GB GDDR5",
                Img = "xbox_one_x_front.jpg",
                Description = "The Xbox One X offers enhanced graphics and performance.",
                Amount = 399
            },

            // Console 5: PlayStation 4 Pro
            new Console
            {
                Id = 5,
                Name = "PlayStation 4 Pro",
                Brand = "Sony",
                ReleaseDate = "2016-11-10",
                Processor = "AMD Jaguar",
                InternalMemory = "1TB HDD",
                Ram = "8GB GDDR5",
                Img = "ps4_pro_front.jpg",
                Description = "The PlayStation 4 Pro offers enhanced graphics and 4K gaming.",
                Amount = 399
            });

            modelBuilder.Entity<Controller>().HasData(
             new Controller
             {
                 Id = 1,
                 Name = "DualSense Wireless Controller",
                 Manufacturer = "Sony",
                 ReleaseDate = "2020-11-12",
                 Platform = "PlayStation 5",
                 ConsoleId = 1,
                 Amount = 8
             },

            new Controller
            {
                Id = 2,
                Name = "Xbox Wireless Controller",
                Manufacturer = "Microsoft",
                ReleaseDate = "2020-11-10",
                Platform = "Xbox Series X",
                ConsoleId = 2,
                Amount = 10
            },

            new Controller
            {
                Id = 3,
                Name = "Joy-Con Controllers",
                Manufacturer = "Nintendo",
                ReleaseDate = "2017-03-03",
                Platform = "Nintendo Switch",
                ConsoleId = 3,
                Amount = 7
            },

            new Controller
            {
                Id = 4,
                Name = "Xbox Wireless Controller",
                Manufacturer = "Microsoft",
                ReleaseDate = "2017-11-07",
                Platform = "Xbox One X",
                ConsoleId = 4,
                Amount = 13
            },

            new Controller
            {
                Id = 5,
                Name = "DualShock 4 Wireless Controller",
                Manufacturer = "Sony",
                ReleaseDate = "2016-11-10",
                Platform = "PlayStation 4 Pro",
                ConsoleId = 5,
                Amount = 6
            },

            new Controller
            {
                Id = 6,
                Name = "Pro Controller",
                Manufacturer = "Nintendo",
                ReleaseDate = "2017-03-03",
                Platform = "Nintendo Switch",
                ConsoleId = 3,
                Amount = 9
            },

            new Controller
            {
                Id = 7,
                Name = "Xbox Elite Wireless Controller Series 2",
                Manufacturer = "Microsoft",
                ReleaseDate = "2019-11-04",
                Platform = "Xbox Series X",
                ConsoleId = 2,
                Amount = 11
            });

            modelBuilder.Entity<Game>().HasData(
            new Game
            {
                Id = 1,
                Name = "The Witcher 3: Wild Hunt",
                Description = "A captivating open-world RPG with epic storytelling.",
                ReleaseDate = "2015-05-19",
                AgeOfAdmission = 18,
                Publisher = "CD Projekt",
                Amount = 29,
                ConsoleId = 1,
                Img = "witcher3.jpg" // Path to the image file
            },

            // Game 2: Red Dead Redemption 2
            new Game
            {
                Id = 2,
                Name = "Red Dead Redemption 2",
                Description = "An immersive western-themed action-adventure game.",
                ReleaseDate = "2018-10-26",
                AgeOfAdmission = 17,
                Publisher = "Rockstar Games",
                Amount = 39,
                ConsoleId = 2,
                Img = "red_dead_redemption2.jpg" // Path to the image file
            },

            // Game 3: The Legend of Zelda: Breath of the Wild
            new Game
            {
                Id = 3,
                Name = "The Legend of Zelda: Breath of the Wild",
                Description = "An iconic action-adventure game set in a vast open world.",
                ReleaseDate = "2017-03-03",
                AgeOfAdmission = 10,
                Publisher = "Nintendo",
                Amount = 49,
                ConsoleId = 3,
                Img = "breath_of_the_wild.jpg" // Path to the image file
            },

            // Game 4: Cyberpunk 2077
            new Game
            {
                Id = 4,
                Name = "Cyberpunk 2077",
                Description = "An open-world RPG set in a dystopian future.",
                ReleaseDate = "2020-12-10",
                AgeOfAdmission = 18,
                Publisher = "CD Projekt",
                Amount = 49,
                ConsoleId = 1,
                Img = "cyberpunk2077.jpg" // Path to the image file
            },

            // Game 5: Grand Theft Auto V
            new Game
            {
                Id = 5,
                Name = "Grand Theft Auto V",
                Description = "An action-packed game in an open-world setting.",
                ReleaseDate = "2013-09-17",
                AgeOfAdmission = 18,
                Publisher = "Rockstar Games",
                Amount = 19,
                ConsoleId = 2,
                Img = "gta5.jpg" // Path to the image file
            },

            // Game 6: Super Mario Odyssey
            new Game
            {
                Id = 6,
                Name = "Super Mario Odyssey",
                Description = "A platformer adventure featuring the beloved Mario.",
                ReleaseDate = "2017-10-27",
                AgeOfAdmission = 6,
                Publisher = "Nintendo",
                Amount = 39,
                ConsoleId = 3,
                Img = "super_mario_odyssey.jpg" // Path to the image file
            },

            // Game 7: Halo Infinite
            new Game
            {
                Id = 7,
                Name = "Halo Infinite",
                Description = "A next-gen shooter in the Halo franchise.",
                ReleaseDate = "2021-12-08",
                AgeOfAdmission = 17,
                Publisher = "Microsoft",
                Amount = 59,
                ConsoleId = 2,
                Img = "halo_infinite.jpg" // Path to the image file
            },

            // Game 8: The Last of Us Part II
            new Game
            {
                Id = 8,
                Name = "The Last of Us Part II",
                Description = "A gripping action-adventure game with emotional storytelling.",
                ReleaseDate = "2020-06-19",
                AgeOfAdmission = 18,
                Publisher = "Sony",
                Amount = 49,
                ConsoleId = 1,
                Img = "the_last_of_us_part_ii.jpg" // Path to the image file
            },

            // Game 9: Minecraft
            new Game
            {
                Id = 9,
                Name = "Minecraft",
                Description = "A sandbox game where you build and explore.",
                ReleaseDate = "2011-11-18",
                AgeOfAdmission = 7,
                Publisher = "Mojang",
                Amount = 29,
                ConsoleId = 3,
                Img = "minecraft.jpg" // Path to the image file
            },

            // Game 10: Call of Duty: Warzone
            new Game
            {
                Id = 10,
                Name = "Call of Duty: Warzone",
                Description = "A battle royale shooter in the Call of Duty universe.",
                ReleaseDate = "2020-03-10",
                AgeOfAdmission = 18,
                Publisher = "Activision",
                Amount = 0,
                ConsoleId = 2,
                Img = "warzone.jpg" // Path to the image file
            },

            // Game 11: Assassin's Creed Valhalla
            new Game
            {
                Id = 11,
                Name = "Assassin's Creed Valhalla",
                Description = "An action RPG set in the Viking Age.",
                ReleaseDate = "2020-11-10",
                AgeOfAdmission = 18,
                Publisher = "Ubisoft",
                Amount = 39,
                ConsoleId = 1,
                Img = "assassins_creed_valhalla.jpg" // Path to the image file
            },

            // Game 12: Animal Crossing: New Horizons
            new Game
            {
                Id = 12,
                Name = "Animal Crossing: New Horizons",
                Description = "A life simulation game with a relaxing island setting.",
                ReleaseDate = "2020-03-20",
                AgeOfAdmission = 3,
                Publisher = "Nintendo",
                Amount = 49,
                ConsoleId = 3,
                Img = "animal_crossing_new_horizons.jpg" // Path to the image file
            },

            // Game 13: Destiny 2
            new Game
            {
                Id = 13,
                Name = "Destiny 2",
                Description = "An online multiplayer shooter with RPG elements.",
                ReleaseDate = "2017-09-06",
                AgeOfAdmission = 16,
                Publisher = "Bungie",
                Amount = 0,
                ConsoleId = 2,
                Img = "destiny_2.jpg" // Path to the image file
            },    // Game 14: Marvel's Spider-Man (continued)
            new Game
            {
                Id = 14,
                Name = "Marvel's Spider-Man",
                Description = "A superhero action-adventure game featuring Spider-Man.",
                ReleaseDate = "2018-09-07",
                AgeOfAdmission = 16,
                Publisher = "Sony",
                Amount = 29,
                ConsoleId = 1,
                Img = "spider_man.jpg" // Path to the image file
            },

            // Game 15: Final Fantasy VII Remake (continued)
            new Game
            {
                Id = 15,
                Name = "Final Fantasy VII Remake",
                Description = "A modern reimagining of the classic RPG, Final Fantasy VII.",
                ReleaseDate = "2020-04-10",
                AgeOfAdmission = 12,
                Publisher = "Square Enix",
                Amount = 49,
                ConsoleId = 1,
                Img = "ffvii_remake.jpg" // Path to the image file
            });
        }

    }
}
