using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using NTRSimulator.Database.Core;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    [DbContext(typeof(NTRSimulatorDbContext))]
    [Migration("20260826120000_AddBackground")]
    public partial class AddBackground : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BackgroundId",
                table: "Accounts",
                type: "bigint",
                nullable: false,
                defaultValue: 1001L);

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BackgroundId = table.Column<long>(type: "bigint", nullable: false),
                    AccountUid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Backgrounds_Accounts_AccountUid",
                        column: x => x.AccountUid,
                        principalTable: "Accounts",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_AccountUid",
                table: "Backgrounds",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_AccountUid_BackgroundId",
                table: "Backgrounds",
                columns: new[] { "AccountUid", "BackgroundId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_BackgroundId",
                table: "Backgrounds",
                column: "BackgroundId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropColumn(
                name: "BackgroundId",
                table: "Accounts");
        }
    }
}
