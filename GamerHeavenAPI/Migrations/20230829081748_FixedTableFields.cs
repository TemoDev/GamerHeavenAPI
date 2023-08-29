using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerHeavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixedTableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Transactions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalCost",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
