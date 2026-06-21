using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddWeaponMod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeaponMods",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeaponModId = table.Column<long>(type: "bigint", nullable: false),
                    Uid = table.Column<long>(type: "bigint", nullable: false),
                    Level = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Field5 = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Field6 = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Field7 = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    AccountUid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponMods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponMods_Accounts_AccountUid",
                        column: x => x.AccountUid,
                        principalTable: "Accounts",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponMods_AccountUid",
                table: "WeaponMods",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponMods_AccountUid_WeaponModId",
                table: "WeaponMods",
                columns: new[] { "AccountUid", "WeaponModId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeaponMods_Uid",
                table: "WeaponMods",
                column: "Uid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeaponMods_WeaponModId",
                table: "WeaponMods",
                column: "WeaponModId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponMods");
        }
    }
}
