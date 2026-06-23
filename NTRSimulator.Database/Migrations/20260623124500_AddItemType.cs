using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using NTRSimulator.Database.Core;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    [DbContext(typeof(NTRSimulatorDbContext))]
    [Migration("20260623124500_AddItemType")]
    public partial class AddItemType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Items",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Items");
        }
    }
}
