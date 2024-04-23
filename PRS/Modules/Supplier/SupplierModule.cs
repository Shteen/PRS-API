using PRS.Core.Models.Request;
using PRS.Service.Services;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules.Supplier
{
    public static class SupplierModule
	{
		public static async void AddSupplierEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/Supplier");

			group.MapGet("/", async (ISupplierService supplierService) => Results.Ok(await supplierService.GetAll()));
			group.MapGet("/supno", async (int supno, ISupplierService supplierService) => {

				var CanV = await supplierService.Get(supno);

				if (CanV == null) return Results.NotFound();

				return Results.Ok(CanV);
			});

			group.MapGet("/page", async (ISupplierService supplierService, int page) =>
			{
				var result = await supplierService.GetAllbyPage(page);
				return Results.Ok(result);
			});

			group.MapGet("/search", async (string search, ISupplierService supplierService) => {

				var employeeDetails = await supplierService.GetBySearch(search);
				return Results.Ok(employeeDetails);
			});

			group.MapPut("/{id:Guid}", async (Guid id, SupplierRequest request, ISupplierService supplierService) => {

				var categoryCode = await supplierService.Update(id, request);
				return Results.Ok(categoryCode);
			});


		}
	}
}
