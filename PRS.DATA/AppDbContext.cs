using PRS.Core.Entites;
using PRS.Modules;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.DATA
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
		public DbSet<Brand> BRND { get; set; }
		public DbSet<Canvas> CanV { get; set; }
		public DbSet<CategoryCode> CategoryCodes { get; set; }

		public DbSet<RawMaterial> RawMaterials { get; set; }

		public DbSet<Category> categories { get; set; }
		public DbSet<RawMatInventory> RMI { get; set; }
		public DbSet<PurchaseOrder> PONum { get; set; }
		public DbSet<RecivingReport> RecRep { get; set; }
		public DbSet<itemsW> Witems { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Canvas>()
				.HasOne(c => c.Brand) 
				.WithMany(b => b.Canvass)  
				.HasForeignKey(c => c.BrandId)  
				.OnDelete(DeleteBehavior.SetNull);
		}
	}

	public class OtherDbContext : DbContext
	{
		public OtherDbContext(DbContextOptions<OtherDbContext> options) : base(options)
		{
		}

		public DbSet<User> User { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

		}
	}

	public class SupplierConnection : DbContext
	{
		public SupplierConnection(DbContextOptions<SupplierConnection> options) : base(options)
		{
		}

		public DbSet<Supplier> SUPPLIER { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
