using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    /// <inheritdoc />
    public partial class RenameGunToGunEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WeaponSkins_AccountUid",
                table: "WeaponSkins");

            migrationBuilder.DropIndex(
                name: "IX_WeaponModSkins_AccountUid",
                table: "WeaponModSkins");

            migrationBuilder.DropIndex(
                name: "IX_WeaponMods_AccountUid",
                table: "WeaponMods");

            migrationBuilder.DropIndex(
                name: "IX_Items_AccountUid",
                table: "Items");

            migrationBuilder.AlterColumn<decimal>(
                name: "Uid",
                table: "WeaponMods",
                type: "numeric(20,0)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "Field7",
                table: "WeaponMods",
                type: "numeric(20,0)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValue: 0L);

            migrationBuilder.AlterColumn<long[]>(
                name: "AvgDuoSubStageIds",
                table: "AvgDuos",
                type: "bigint[]",
                nullable: false,
                defaultValue: new long[0],
                oldClrType: typeof(long[]),
                oldType: "bigint[]",
                oldNullable: true,
                oldDefaultValue: new long[0]);

            migrationBuilder.AlterColumn<long[]>(
                name: "AvgDuoMainStageIds",
                table: "AvgDuos",
                type: "bigint[]",
                nullable: false,
                defaultValue: new long[0],
                oldClrType: typeof(long[]),
                oldType: "bigint[]",
                oldNullable: true,
                oldDefaultValue: new long[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Uid",
                table: "WeaponMods",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(20,0)");

            migrationBuilder.AlterColumn<long>(
                name: "Field7",
                table: "WeaponMods",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(decimal),
                oldType: "numeric(20,0)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<long[]>(
                name: "AvgDuoSubStageIds",
                table: "AvgDuos",
                type: "bigint[]",
                nullable: true,
                defaultValue: new long[0],
                oldClrType: typeof(long[]),
                oldType: "bigint[]",
                oldDefaultValue: new long[0]);

            migrationBuilder.AlterColumn<long[]>(
                name: "AvgDuoMainStageIds",
                table: "AvgDuos",
                type: "bigint[]",
                nullable: true,
                defaultValue: new long[0],
                oldClrType: typeof(long[]),
                oldType: "bigint[]",
                oldDefaultValue: new long[0]);

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSkins_AccountUid",
                table: "WeaponSkins",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponModSkins_AccountUid",
                table: "WeaponModSkins",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponMods_AccountUid",
                table: "WeaponMods",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AccountUid",
                table: "Items",
                column: "AccountUid");
        }
    }
}
