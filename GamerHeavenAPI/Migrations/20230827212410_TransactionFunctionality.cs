using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerHeavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class TransactionFunctionality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Controllers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Consoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });

            migrationBuilder.UpdateData(
                table: "Consoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Consoles");

            migrationBuilder.UpdateData(
                table: "Consoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Consoles");

            migrationBuilder.UpdateData(
                table: "Consoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: "Consoles");

            migrationBuilder.UpdateData(
                table: "Consoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: "Consoles");

            migrationBuilder.UpdateData(
                table: "Consoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Category",
                value: "Consoles");

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Controllers");

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Controllers");

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: "Controllers");

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: "Controllers");

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Category",
                value: "Controllers");

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Category",
                value: "Controllers");

            migrationBuilder.UpdateData(
                table: "Controllers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Category",
                value: "Controllers");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "Category",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "Category",
                value: "Games");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Controllers");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Consoles");
        }
    }
}
