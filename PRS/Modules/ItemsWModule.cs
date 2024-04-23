using PRS.Core.Models.Request;
using PRS.Service.Services;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules
{
    public static class ItemsWModule
	{
		public static async void AddItemsWEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/ItemsW");

			group.MapGet("/", async (IitemsWService ItemsWService) => Results.Ok(await ItemsWService.GetAll()));

			group.MapGet("/{id:Guid}", async (Guid id, IitemsWService ItemsWService) => {

				var ItemsW = await ItemsWService.GetById(id);

				if (ItemsW == null) return Results.NotFound();

				return Results.Ok(ItemsW);
			});

			group.MapGet("/page", async (IitemsWService ItemsWService, int page) =>
			{
				var result = await ItemsWService. GetAllbyPage(page);
				return Results.Ok(result);
			});

			group.MapGet("/search", async (string search, IitemsWService ItemsWService, int page) => {

				var employeeDetails = await ItemsWService.GetBySearch(search, page);
				return Results.Ok(employeeDetails);

				
			});


			group.MapPost("/", async (ItemsWRequest request, IitemsWService ItemsWService) =>
			{
				var newItemsW = await ItemsWService.Create(request);
				return Results.Created($"api/ItemsW/{newItemsW.Id}", newItemsW);
			});

			group.MapPut("/{id:Guid}", async (Guid id, ItemsWRequest request, IitemsWService ItemsWService) => {

				var ItemsW = await ItemsWService.Update(id, request);
				return Results.Ok(ItemsW);
			});

			group.MapDelete("/{id:Guid}", async (Guid id, IitemsWService ItemsWService) =>
			{
				var success = await ItemsWService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});


		}
	}
}
