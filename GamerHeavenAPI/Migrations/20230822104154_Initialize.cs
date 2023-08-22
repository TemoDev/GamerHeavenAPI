using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamerHeavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalMemory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Controllers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controllers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Controllers_Consoles_ConsoleId",
                        column: x => x.ConsoleId,
                        principalTable: "Consoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeOfAdmission = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Consoles_ConsoleId",
                        column: x => x.ConsoleId,
                        principalTable: "Consoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Consoles",
                columns: new[] { "Id", "Amount", "Brand", "Description", "Img", "InternalMemory", "Name", "Processor", "Ram", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 499, "Sony", "The PlayStation 5 is Sony's latest gaming console.", "ps5_front.jpg", "825GB SSD", "PlayStation 5", "AMD Ryzen Zen 2", "16GB GDDR6", "2020-11-12" },
                    { 2, 499, "Microsoft", "The Xbox Series X delivers next-gen gaming experiences.", "xbox_series_x_front.jpg", "1TB SSD", "Xbox Series X", "AMD Zen 2", "16GB GDDR6", "2020-11-10" },
                    { 3, 299, "Nintendo", "The Nintendo Switch is a hybrid gaming console.", "nintendo_switch_front.jpg", "32GB", "Nintendo Switch", "NVIDIA Custom Tegra", "4GB", "2017-03-03" },
                    { 4, 399, "Microsoft", "The Xbox One X offers enhanced graphics and performance.", "xbox_one_x_front.jpg", "1TB HDD", "Xbox One X", "AMD Jaguar", "12GB GDDR5", "2017-11-07" },
                    { 5, 399, "Sony", "The PlayStation 4 Pro offers enhanced graphics and 4K gaming.", "ps4_pro_front.jpg", "1TB HDD", "PlayStation 4 Pro", "AMD Jaguar", "8GB GDDR5", "2016-11-10" }
                });

            migrationBuilder.InsertData(
                table: "Controllers",
                columns: new[] { "Id", "ConsoleId", "Manufacturer", "Name", "Platform", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, "Sony", "DualSense Wireless Controller", "PlayStation 5", "2020-11-12" },
                    { 2, 2, "Microsoft", "Xbox Wireless Controller", "Xbox Series X", "2020-11-10" },
                    { 3, 3, "Nintendo", "Joy-Con Controllers", "Nintendo Switch", "2017-03-03" },
                    { 4, 4, "Microsoft", "Xbox Wireless Controller", "Xbox One X", "2017-11-07" },
                    { 5, 5, "Sony", "DualShock 4 Wireless Controller", "PlayStation 4 Pro", "2016-11-10" },
                    { 6, 3, "Nintendo", "Pro Controller", "Nintendo Switch", "2017-03-03" },
                    { 7, 2, "Microsoft", "Xbox Elite Wireless Controller Series 2", "Xbox Series X", "2019-11-04" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeOfAdmission", "Amount", "ConsoleId", "Description", "Img", "Name", "Publisher", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 18, 29, 1, "A captivating open-world RPG with epic storytelling.", "witcher3.jpg", "The Witcher 3: Wild Hunt", "CD Projekt", "2015-05-19" },
                    { 2, 17, 39, 2, "An immersive western-themed action-adventure game.", "red_dead_redemption2.jpg", "Red Dead Redemption 2", "Rockstar Games", "2018-10-26" },
                    { 3, 10, 49, 3, "An iconic action-adventure game set in a vast open world.", "breath_of_the_wild.jpg", "The Legend of Zelda: Breath of the Wild", "Nintendo", "2017-03-03" },
                    { 4, 18, 49, 1, "An open-world RPG set in a dystopian future.", "cyberpunk2077.jpg", "Cyberpunk 2077", "CD Projekt", "2020-12-10" },
                    { 5, 18, 19, 2, "An action-packed game in an open-world setting.", "gta5.jpg", "Grand Theft Auto V", "Rockstar Games", "2013-09-17" },
                    { 6, 6, 39, 3, "A platformer adventure featuring the beloved Mario.", "super_mario_odyssey.jpg", "Super Mario Odyssey", "Nintendo", "2017-10-27" },
                    { 7, 17, 59, 2, "A next-gen shooter in the Halo franchise.", "halo_infinite.jpg", "Halo Infinite", "Microsoft", "2021-12-08" },
                    { 8, 18, 49, 1, "A gripping action-adventure game with emotional storytelling.", "the_last_of_us_part_ii.jpg", "The Last of Us Part II", "Sony", "2020-06-19" },
                    { 9, 7, 29, 3, "A sandbox game where you build and explore.", "minecraft.jpg", "Minecraft", "Mojang", "2011-11-18" },
                    { 10, 18, 0, 2, "A battle royale shooter in the Call of Duty universe.", "warzone.jpg", "Call of Duty: Warzone", "Activision", "2020-03-10" },
                    { 11, 18, 39, 1, "An action RPG set in the Viking Age.", "assassins_creed_valhalla.jpg", "Assassin's Creed Valhalla", "Ubisoft", "2020-11-10" },
                    { 12, 3, 49, 3, "A life simulation game with a relaxing island setting.", "animal_crossing_new_horizons.jpg", "Animal Crossing: New Horizons", "Nintendo", "2020-03-20" },
                    { 13, 16, 0, 2, "An online multiplayer shooter with RPG elements.", "destiny_2.jpg", "Destiny 2", "Bungie", "2017-09-06" },
                    { 14, 16, 29, 1, "A superhero action-adventure game featuring Spider-Man.", "spider_man.jpg", "Marvel's Spider-Man", "Sony", "2018-09-07" },
                    { 15, 12, 49, 1, "A modern reimagining of the classic RPG, Final Fantasy VII.", "ffvii_remake.jpg", "Final Fantasy VII Remake", "Square Enix", "2020-04-10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Controllers_ConsoleId",
                table: "Controllers",
                column: "ConsoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_ConsoleId",
                table: "Games",
                column: "ConsoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Controllers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Consoles");
        }
    }
}
