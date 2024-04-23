using PRS.Core.Entites;
using PRS.Core.Models.Request;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules
{
    public static class RawMaterialModule
	{
		public static async void AddRawMaterialEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/RawMaterials");

			group.MapGet("/", async (IRawMaterialService RawMaterialService) => Results.Ok(await RawMaterialService.GetAll()));

			group.MapGet("/{id:Guid}", async (Guid id, IRawMaterialService RawMaterialService) => {

				var rawmatt = await RawMaterialService.GetById(id);

				if (rawmatt == null) return Results.NotFound();

				return Results.Ok(rawmatt);
			});



			group.MapPost("/", async (RawMaterialRequest request, IRawMaterialService RawMaterialService) =>
			{
				var newrawmatt = await RawMaterialService.Create(request);
				return Results.Created($"api/Branch/{newrawmatt.id}", newrawmatt);
			});

			group.MapPut("/{id:Guid}", async (Guid id, RawMaterialRequest request, IRawMaterialService RawMaterialService) => {

				var rawmatt = await RawMaterialService.Update(id, request);
				return Results.Ok(rawmatt);
			});

			group.MapDelete("/{id:Guid}", async (Guid id, IRawMaterialService RawMaterialService) =>
			{
				var success = await RawMaterialService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});


		}
	}
}
