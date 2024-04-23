using PRS.Core.Models.Request;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules
{
    public static class RawMatInventoryModule
	{

		public static async void AddRawMatInventoryEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/RawMatInventory");

			group.MapGet("/", async (IRawMatInventoryService RawMatInventoryService) => Results.Ok(await RawMatInventoryService.GetAll()));

			group.MapGet("/{id:Guid}", async (Guid id, IRawMatInventoryService RawMatInventoryService) => {

				var RawMI = await RawMatInventoryService.GetById(id);

				if (RawMI == null) return Results.NotFound();

				return Results.Ok(RawMI);
			});



			group.MapPost("/", async (RawMatInventoryRequest request, IRawMatInventoryService RawMatInventoryService) =>
			{
				var newRawMI = await RawMatInventoryService.Create(request);
				return Results.Created($"api/Branch/{newRawMI.Id}", newRawMI);
			});

			group.MapPut("/{id:Guid}", async (Guid id, RawMatInventoryRequest request, IRawMatInventoryService RawMatInventoryService) => {

				var newRawMI = await RawMatInventoryService.Update(id, request);
				return Results.Ok(newRawMI);
			});

			group.MapDelete("/{id:Guid}", async (Guid id, IRawMatInventoryService RawMatInventoryService) =>
			{
				var success = await RawMatInventoryService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});


		}

	}
}
