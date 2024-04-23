using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.DATA.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.DATA
{
	public static class Bootstrapper
	{
		public static IServiceCollection PRSData(this IServiceCollection services, IConfiguration configuration)
		{

			var connectionString = configuration.GetConnectionString("DefaultConnection");
			var otherConnectionString = configuration.GetConnectionString("OtherConnection");
			var SupplierConnectionString = configuration.GetConnectionString("SupplierConnection");
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
			services.AddDbContext<OtherDbContext>(options => options.UseSqlServer(otherConnectionString));
			services.AddDbContext<SupplierConnection>(options => options.UseSqlServer(SupplierConnectionString));
			services.AddScoped<ICanvasRepository, CanvasRepository>();
			services.AddScoped<ICategoryCodeRepository, CategoryCodeRepository>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IRawMaterialRepository, RawMaterialRepository>();
			services.AddScoped<IRawMatInventoryRepository, RawMatInventoryRepository>();
			services.AddScoped<IRecivingReport, RecivingReportRepository>();
			services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
			services.AddScoped<ISupplierRepository, SupplierRepository>();
			services.AddScoped<IBrandRepository, BrandRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IitemsWRepository, ItemsWRepository>();
			return services;
		}
	}
}
