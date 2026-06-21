using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddWeaponSkin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeaponSkins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeaponSkinId = table.Column<long>(type: "bigint", nullable: false),
                    AccountUid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponSkins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponSkins_Accounts_AccountUid",
                        column: x => x.AccountUid,
                        principalTable: "Accounts",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSkins_AccountUid",
                table: "WeaponSkins",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSkins_AccountUid_WeaponSkinId",
                table: "WeaponSkins",
                columns: new[] { "AccountUid", "WeaponSkinId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSkins_WeaponSkinId",
                table: "WeaponSkins",
                column: "WeaponSkinId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponSkins");
        }
    }
}
