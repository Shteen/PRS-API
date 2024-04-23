using PRS.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.SERVICE
{
    public static class Bootstrapper
	{
		public static IServiceCollection PRSService(this IServiceCollection services)
		{
			services.AddTransient<ICanvasService, CanvasService>();
			services.AddTransient<ICategoryCodeService, CategoryCodeService>();
			services.AddTransient<ICategoryService, CategoryService>();
			services.AddTransient<IRawMaterialService, RawMaterialService>();
			services.AddTransient<IRawMatInventoryService, RawMatInventoryService>();
			services.AddTransient<IPurchaseOrderService, PurchaseOrderService>();
			services.AddTransient<IRecivingReportService, RecivingReportService>();
			services.AddTransient<ISupplierService, SupplierService>();
			services.AddTransient<IUserService, UserService>();
			services.AddTransient<IitemsWService, ItemsWService>();
			services.AddTransient<IBrandService, BrandService>();
			return services;
		}
	}
}
