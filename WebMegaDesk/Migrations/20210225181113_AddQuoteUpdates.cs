using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMegaDesk.Migrations
{
    public partial class AddQuoteUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerFullName",
                table: "Quote");

            migrationBuilder.AddColumn<DateTime>(
                name: "QuoteDate",
                table: "Quote",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteDate",
                table: "Quote");

            migrationBuilder.AddColumn<string>(
                name: "CustomerFullName",
                table: "Quote",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
