using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    /// <inheritdoc />
    public partial class LinkGunAndCostumeToAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guns_Id",
                table: "Guns");

            migrationBuilder.DropIndex(
                name: "IX_Costumes_Id",
                table: "Costumes");

            migrationBuilder.AlterColumn<int>(
                name: "Level",
                table: "Guns",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "AccountUid",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AccountUid",
                table: "Costumes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Guns_AccountUid",
                table: "Guns",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_GunId",
                table: "Guns",
                column: "GunId");

            migrationBuilder.CreateIndex(
                name: "IX_Costumes_AccountUid",
                table: "Costumes",
                column: "AccountUid");

            migrationBuilder.CreateIndex(
                name: "IX_Costumes_CostumeId",
                table: "Costumes",
                column: "CostumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Costumes_Accounts_AccountUid",
                table: "Costumes",
                column: "AccountUid",
                principalTable: "Accounts",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_Accounts_AccountUid",
                table: "Guns",
                column: "AccountUid",
                principalTable: "Accounts",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Costumes_Accounts_AccountUid",
                table: "Costumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Guns_Accounts_AccountUid",
                table: "Guns");

            migrationBuilder.DropIndex(
                name: "IX_Guns_AccountUid",
                table: "Guns");

            migrationBuilder.DropIndex(
                name: "IX_Guns_GunId",
                table: "Guns");

            migrationBuilder.DropIndex(
                name: "IX_Costumes_AccountUid",
                table: "Costumes");

            migrationBuilder.DropIndex(
                name: "IX_Costumes_CostumeId",
                table: "Costumes");

            migrationBuilder.DropColumn(
                name: "AccountUid",
                table: "Guns");

            migrationBuilder.DropColumn(
                name: "AccountUid",
                table: "Costumes");

            migrationBuilder.AlterColumn<long>(
                name: "Level",
                table: "Guns",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Guns_Id",
                table: "Guns",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Costumes_Id",
                table: "Costumes",
                column: "Id",
                unique: true);
        }
    }
}
