﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRS.DATA;

#nullable disable

namespace PRS.DATA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240321073308_ink5")]
    partial class ink5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PRS.Core.Entites.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BRND");
                });

            modelBuilder.Entity("PRS.Core.Entites.Canvas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CVSNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CostCS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("CostPC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DNONUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNOType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EIitem")
                        .HasColumnType("int");

                    b.Property<string>("Factory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PCCS")
                        .HasColumnType("int");

                    b.Property<string>("QTY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReqBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReqDescript")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UMCS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UMPC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("brandID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("itemsWID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("keyperson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("number1")
                        .HasColumnType("int");

                    b.Property<bool>("ppe")
                        .HasColumnType("bit");

                    b.Property<int?>("supno")
                        .HasColumnType("int");

                    b.Property<Guid>("supplierID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("supplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("taxrate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("terms")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("brandID");

                    b.HasIndex("itemsWID");

                    b.HasIndex("supplierID");

                    b.ToTable("CanV");
                });

            modelBuilder.Entity("PRS.Core.Entites.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CatDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryCodeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNOTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CategoryCodeId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("PRS.Core.Entites.CategoryCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNOTYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoryCodes");
                });

            modelBuilder.Entity("PRS.Core.Entites.PurchaseOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CVSNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CanReffId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CatDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CostCS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("CostPC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DNONUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNOType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EIitem")
                        .HasColumnType("int");

                    b.Property<string>("Factory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PCCS")
                        .HasColumnType("int");

                    b.Property<string>("PONumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QTY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReqBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReqDescript")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UMCS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UMPC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keyperson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("number1")
                        .HasColumnType("int");

                    b.Property<bool>("ppe")
                        .HasColumnType("bit");

                    b.Property<int?>("supno")
                        .HasColumnType("int");

                    b.Property<string>("supplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("taxrate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("terms")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CanReffId");

                    b.ToTable("PONum");
                });

            modelBuilder.Entity("PRS.Core.Entites.RawMatInventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CVSNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DeliveryDate")
                        .HasColumnType("float");

                    b.Property<double>("EXP")
                        .HasColumnType("float");

                    b.Property<string>("ItemDes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("QTY")
                        .HasColumnType("float");

                    b.Property<string>("RawMatInvNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RawMatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UCaVat")
                        .HasColumnType("float");

                    b.Property<string>("UM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RMI");
                });

            modelBuilder.Entity("PRS.Core.Entites.RawMaterial", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CurrentInventory")
                        .HasColumnType("float");

                    b.Property<string>("ItemDes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RawMaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("RawMaterials");
                });

            modelBuilder.Entity("PRS.Core.Entites.RecivingReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CVSNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Factory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("POBalanceQTY")
                        .HasColumnType("float");

                    b.Property<string>("PONumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("POenterdQTY")
                        .HasColumnType("float");

                    b.Property<double>("POorderQTY")
                        .HasColumnType("float");

                    b.Property<double>("QTY")
                        .HasColumnType("float");

                    b.Property<string>("RRdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RRnum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RawMaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReqBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReqDescript")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UCaVat")
                        .HasColumnType("float");

                    b.Property<double>("UCb4Vat")
                        .HasColumnType("float");

                    b.Property<string>("UM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keyperson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("number1")
                        .HasColumnType("int");

                    b.Property<bool>("ppe")
                        .HasColumnType("bit");

                    b.Property<int?>("supno")
                        .HasColumnType("int");

                    b.Property<string>("supplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("vat")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("RecRep");
                });

            modelBuilder.Entity("PRS.Core.Entites.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("keyperson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("number1")
                        .HasColumnType("int");

                    b.Property<int?>("supno")
                        .HasColumnType("int");

                    b.Property<string>("supplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terms")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("PRS.Modules.itemsW", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CatDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CostCS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("CostPC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DNONUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNOType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EIitem")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PCCS")
                        .HasColumnType("int");

                    b.Property<string>("UMCS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UMPC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("categoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("taxrate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("categoryID");

                    b.ToTable("Witems");
                });

            modelBuilder.Entity("PRS.Core.Entites.Canvas", b =>
                {
                    b.HasOne("PRS.Core.Entites.Brand", "brand")
                        .WithMany()
                        .HasForeignKey("brandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRS.Modules.itemsW", "items")
                        .WithMany()
                        .HasForeignKey("itemsWID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRS.Core.Entites.Supplier", "supplier")
                        .WithMany()
                        .HasForeignKey("supplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brand");

                    b.Navigation("items");

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("PRS.Core.Entites.Category", b =>
                {
                    b.HasOne("PRS.Core.Entites.CategoryCode", "CategoryCodes")
                        .WithMany()
                        .HasForeignKey("CategoryCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryCodes");
                });

            modelBuilder.Entity("PRS.Core.Entites.PurchaseOrder", b =>
                {
                    b.HasOne("PRS.Core.Entites.Canvas", "CanReff")
                        .WithMany()
                        .HasForeignKey("CanReffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CanReff");
                });

            modelBuilder.Entity("PRS.Modules.itemsW", b =>
                {
                    b.HasOne("PRS.Core.Entites.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });
#pragma warning restore 612, 618
        }
    }
}
