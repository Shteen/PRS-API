using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRS.DATA.Migrations
{
    /// <inheritdoc />
    public partial class initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BRND",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRND", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNOTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RMI",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RawMatInvNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVSNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RawMatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QTY = table.Column<double>(type: "float", nullable: false),
                    UCaVat = table.Column<double>(type: "float", nullable: false),
                    DeliveryDate = table.Column<double>(type: "float", nullable: false),
                    EXP = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RawMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentInventory = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RecRep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RRnum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RRdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PONumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVSNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RawMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Factory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqDescript = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ppe = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supno = table.Column<int>(type: "int", nullable: true),
                    number1 = table.Column<int>(type: "int", nullable: true),
                    keyperson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QTY = table.Column<double>(type: "float", nullable: false),
                    UCb4Vat = table.Column<double>(type: "float", nullable: false),
                    UCaVat = table.Column<double>(type: "float", nullable: false),
                    vat = table.Column<double>(type: "float", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    POorderQTY = table.Column<double>(type: "float", nullable: false),
                    POBalanceQTY = table.Column<double>(type: "float", nullable: false),
                    POenterdQTY = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecRep", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNOTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_categories_CategoryCodes_CategoryCodeId",
                        column: x => x.CategoryCodeId,
                        principalTable: "CategoryCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Witems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EIitem = table.Column<int>(type: "int", nullable: false),
                    DNOType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNONUMBER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxrate = table.Column<float>(type: "real", nullable: true),
                    UMPC = table.Column<float>(type: "real", nullable: false),
                    CostPC = table.Column<float>(type: "real", nullable: false),
                    UMCS = table.Column<float>(type: "real", nullable: false),
                    CostCS = table.Column<float>(type: "real", nullable: false),
                    PCCS = table.Column<float>(type: "real", nullable: false),
                    categoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Witems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Witems_categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CanV",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CVSNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Factory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqDescript = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ppe = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supno = table.Column<int>(type: "int", nullable: true),
                    number1 = table.Column<int>(type: "int", nullable: true),
                    keyperson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EIitem = table.Column<int>(type: "int", nullable: false),
                    DNOType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNONUMBER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxrate = table.Column<float>(type: "real", nullable: true),
                    UMPC = table.Column<float>(type: "real", nullable: false),
                    CostPC = table.Column<float>(type: "real", nullable: false),
                    UMCS = table.Column<float>(type: "real", nullable: false),
                    CostCS = table.Column<float>(type: "real", nullable: false),
                    PCCS = table.Column<float>(type: "real", nullable: false),
                    QTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brandID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    itemsWID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanV", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CanV_BRND_brandID",
                        column: x => x.brandID,
                        principalTable: "BRND",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CanV_Witems_itemsWID",
                        column: x => x.itemsWID,
                        principalTable: "Witems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PONum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PONumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVSNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Factory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqDescript = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ppe = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supno = table.Column<int>(type: "int", nullable: true),
                    number1 = table.Column<int>(type: "int", nullable: true),
                    keyperson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EIitem = table.Column<int>(type: "int", nullable: false),
                    DNOType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNONUMBER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxrate = table.Column<float>(type: "real", nullable: true),
                    UMPC = table.Column<float>(type: "real", nullable: false),
                    CostPC = table.Column<float>(type: "real", nullable: false),
                    UMCS = table.Column<float>(type: "real", nullable: false),
                    CostCS = table.Column<float>(type: "real", nullable: false),
                    PCCS = table.Column<float>(type: "real", nullable: false),
                    QTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanReffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PONum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PONum_CanV_CanReffId",
                        column: x => x.CanReffId,
                        principalTable: "CanV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanV_brandID",
                table: "CanV",
                column: "brandID");

            migrationBuilder.CreateIndex(
                name: "IX_CanV_itemsWID",
                table: "CanV",
                column: "itemsWID");

            migrationBuilder.CreateIndex(
                name: "IX_PONum_CanReffId",
                table: "PONum",
                column: "CanReffId");

            migrationBuilder.CreateIndex(
                name: "IX_Witems_categoryID",
                table: "Witems",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_categories_CategoryCodeId",
                table: "categories",
                column: "CategoryCodeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PONum");

            migrationBuilder.DropTable(
                name: "RMI");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "RecRep");

            migrationBuilder.DropTable(
                name: "CanV");

            migrationBuilder.DropTable(
                name: "BRND");

            migrationBuilder.DropTable(
                name: "Witems");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "CategoryCodes");
        }
    }
}
