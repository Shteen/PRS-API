using PRS.Core.Models.Request;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules
{
    public static class PurchaseOrderModule
	{

		public static async void AddPurchaseOrderEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/PurchaseOrder");

			group.MapGet("/", async (IPurchaseOrderService purchaseOrderService) => Results.Ok(await purchaseOrderService.GetAll()));

			group.MapGet("/{Id:Guid}", async (Guid Id, IPurchaseOrderService purchaseOrderService) => {

				var purIrder = await purchaseOrderService.GetById(Id);

				if (purIrder == null) return Results.NotFound();

				return Results.Ok(purIrder);
			});



			group.MapPost("/", async (PurchaseOrderRequest request, IPurchaseOrderService purchaseOrderService) =>
			{
				var purchaseOrder = await purchaseOrderService.Create(request);
				return Results.Created($"api/PurchaseOrder/{purchaseOrder.Id}", purchaseOrder);
			});

			group.MapPut("/{id:Guid}", async (Guid id, PurchaseOrderRequest request, IPurchaseOrderService purchaseOrderService) => {

				var purIrder = await purchaseOrderService.Update(id, request);
				return Results.Ok(purIrder);
			});

			group.MapDelete("/{id:Guid}", async (Guid id, IPurchaseOrderService purchaseOrderService) =>
			{
				var success = await purchaseOrderService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});


		}
	}
}
