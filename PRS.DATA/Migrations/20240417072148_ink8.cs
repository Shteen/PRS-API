using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRS.DATA.Migrations
{
    /// <inheritdoc />
    public partial class ink8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CanV_BRND_brandID",
                table: "CanV");

            migrationBuilder.RenameColumn(
                name: "brandID",
                table: "CanV",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_CanV_brandID",
                table: "CanV",
                newName: "IX_CanV_BrandId");

            migrationBuilder.AlterColumn<Guid>(
                name: "BrandId",
                table: "CanV",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_CanV_BRND_BrandId",
                table: "CanV",
                column: "BrandId",
                principalTable: "BRND",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CanV_BRND_BrandId",
                table: "CanV");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "CanV",
                newName: "brandID");

            migrationBuilder.RenameIndex(
                name: "IX_CanV_BrandId",
                table: "CanV",
                newName: "IX_CanV_brandID");

            migrationBuilder.AlterColumn<Guid>(
                name: "brandID",
                table: "CanV",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CanV_BRND_brandID",
                table: "CanV",
                column: "brandID",
                principalTable: "BRND",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
