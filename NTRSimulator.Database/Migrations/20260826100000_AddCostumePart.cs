using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using NTRSimulator.Database.Core;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    [DbContext(typeof(NTRSimulatorDbContext))]
    [Migration("20260826100000_AddCostumePart")]
    public partial class AddCostumePart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CostumeParts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CostumePartId = table.Column<long>(type: "bigint", nullable: false),
                    AccountUid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostumeParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostumeParts_Accounts_AccountUid",
                        column: x => x.AccountUid,
                        principalTable: "Accounts",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostumeParts_AccountUid",
                table: "CostumeParts",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_CostumeParts_AccountUid_CostumePartId",
                table: "CostumeParts",
                columns: new[] { "AccountUid", "CostumePartId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CostumeParts_CostumePartId",
                table: "CostumeParts",
                column: "CostumePartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostumeParts");
        }
    }
}
