using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using NTRSimulator.Database.Core;

#nullable disable

namespace NTRSimulator.Database.Migrations
{
    [DbContext(typeof(NTRSimulatorDbContext))]
    [Migration("20260828100000_AddGunWeaponLoadoutFields")]
    public partial class AddGunWeaponLoadoutFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Exp",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 120L);

            migrationBuilder.AddColumn<long>(
                name: "Energy",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 120L);

            migrationBuilder.AddColumn<long>(
                name: "GunClass",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 1L);

            migrationBuilder.AddColumn<long>(
                name: "CostumeParts",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Grade",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AuthLevel",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "WeaponId",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsGetPublicTalentSkillItem",
                table: "Guns",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAllTalentUnlock",
                table: "Guns",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "Preset",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PresetId",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TalentResetNum",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long[]>(
                name: "PrivateTalentSkillItems",
                table: "Guns",
                type: "bigint[]",
                nullable: false,
                defaultValue: new long[] { 0L, 0L, 0L });

            migrationBuilder.AddColumn<long[]>(
                name: "PublicTalentSkillItems",
                table: "Guns",
                type: "bigint[]",
                nullable: false,
                defaultValue: new long[] { 0L, 0L, 0L });

            migrationBuilder.AddColumn<decimal[]>(
                name: "PublicTalentSkillItemsUid",
                table: "Guns",
                type: "numeric(20,0)[]",
                nullable: false,
                defaultValue: new decimal[] { 0m, 0m, 0m });

            migrationBuilder.AddColumn<Dictionary<ulong, uint>>(
                name: "TalentTree",
                table: "Guns",
                type: "jsonb",
                nullable: false,
                defaultValueSql: "'{}'::jsonb");

            migrationBuilder.AddColumn<Dictionary<uint, uint>>(
                name: "GunTalentConsume",
                table: "Guns",
                type: "jsonb",
                nullable: false,
                defaultValueSql: "'{}'::jsonb");

            migrationBuilder.AddColumn<long>(
                name: "LoveLevel",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 1L);

            migrationBuilder.AddColumn<long>(
                name: "LoveExp",
                table: "Guns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Flags",
                table: "Weapons",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EquippedSkinId",
                table: "Weapons",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long[]>(
                name: "EquippedModIds",
                table: "Weapons",
                type: "bigint[]",
                nullable: false,
                defaultValue: Array.Empty<long>());

            migrationBuilder.CreateIndex(
                name: "IX_Guns_WeaponId",
                table: "Guns",
                column: "WeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guns_WeaponId",
                table: "Guns");

            migrationBuilder.DropColumn(name: "Exp", table: "Guns");
            migrationBuilder.DropColumn(name: "Energy", table: "Guns");
            migrationBuilder.DropColumn(name: "GunClass", table: "Guns");
            migrationBuilder.DropColumn(name: "CostumeParts", table: "Guns");
            migrationBuilder.DropColumn(name: "Grade", table: "Guns");
            migrationBuilder.DropColumn(name: "AuthLevel", table: "Guns");
            migrationBuilder.DropColumn(name: "WeaponId", table: "Guns");
            migrationBuilder.DropColumn(name: "IsGetPublicTalentSkillItem", table: "Guns");
            migrationBuilder.DropColumn(name: "IsAllTalentUnlock", table: "Guns");
            migrationBuilder.DropColumn(name: "Preset", table: "Guns");
            migrationBuilder.DropColumn(name: "PresetId", table: "Guns");
            migrationBuilder.DropColumn(name: "TalentResetNum", table: "Guns");
            migrationBuilder.DropColumn(name: "PrivateTalentSkillItems", table: "Guns");
            migrationBuilder.DropColumn(name: "PublicTalentSkillItems", table: "Guns");
            migrationBuilder.DropColumn(name: "PublicTalentSkillItemsUid", table: "Guns");
            migrationBuilder.DropColumn(name: "TalentTree", table: "Guns");
            migrationBuilder.DropColumn(name: "GunTalentConsume", table: "Guns");
            migrationBuilder.DropColumn(name: "LoveLevel", table: "Guns");
            migrationBuilder.DropColumn(name: "LoveExp", table: "Guns");

            migrationBuilder.DropColumn(name: "Flags", table: "Weapons");
            migrationBuilder.DropColumn(name: "EquippedSkinId", table: "Weapons");
            migrationBuilder.DropColumn(name: "EquippedModIds", table: "Weapons");
        }
    }
}
