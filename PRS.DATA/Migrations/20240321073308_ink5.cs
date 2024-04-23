using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRS.DATA.Migrations
{
    /// <inheritdoc />
    public partial class ink5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "supplierID",
                table: "CanV",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supno = table.Column<int>(type: "int", nullable: true),
                    number1 = table.Column<int>(type: "int", nullable: true),
                    keyperson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terms = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanV_supplierID",
                table: "CanV",
                column: "supplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_CanV_Supplier_supplierID",
                table: "CanV",
                column: "supplierID",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CanV_Supplier_supplierID",
                table: "CanV");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_CanV_supplierID",
                table: "CanV");

            migrationBuilder.DropColumn(
                name: "supplierID",
                table: "CanV");
        }
    }
}
