using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using NTRSimulator.Database.Core;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    [DbContext(typeof(NTRSimulatorDbContext))]
    [Migration("20260623120000_RemoveAvgDuoItemIds")]
    public partial class RemoveAvgDuoItemIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                ALTER TABLE "AvgDuos" DROP COLUMN IF EXISTS "AvgDuoItemIds";
                """);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long[]>(
                name: "AvgDuoItemIds",
                table: "AvgDuos",
                type: "bigint[]",
                nullable: false,
                defaultValue: Array.Empty<long>());
        }
    }
}
