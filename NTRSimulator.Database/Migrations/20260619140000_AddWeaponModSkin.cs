using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddWeaponModSkin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeaponModSkins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeaponModSkinId = table.Column<long>(type: "bigint", nullable: false),
                    AccountUid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponModSkins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponModSkins_Accounts_AccountUid",
                        column: x => x.AccountUid,
                        principalTable: "Accounts",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponModSkins_AccountUid",
                table: "WeaponModSkins",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponModSkins_AccountUid_WeaponModSkinId",
                table: "WeaponModSkins",
                columns: new[] { "AccountUid", "WeaponModSkinId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeaponModSkins_WeaponModSkinId",
                table: "WeaponModSkins",
                column: "WeaponModSkinId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponModSkins");
        }
    }
}
