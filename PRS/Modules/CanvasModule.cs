using PRS.Core.Models.Request;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules
{
    public static class CanvasModule
	{

		public static async void AddCanvasEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/Canvas");

			group.MapGet("/", async (ICanvasService CanvasService) => Results.Ok(await CanvasService.GetAll()));

			group.MapGet("/{id:Guid}", async (Guid id, ICanvasService CanvasService) => {

				var CanV = await CanvasService.GetById(id);

				if (CanV == null) return Results.NotFound();

				return Results.Ok(CanV);
			});



			group.MapPost("/", async (CanvasRequest request, ICanvasService CanvasService) =>
			{
				var newCanvas = await CanvasService.Create(request);
				return Results.Created($"api/Canvas/{newCanvas.Id}", newCanvas);
			});  

			group.MapPut("/{id:Guid}", async (Guid id, CanvasRequest request, ICanvasService CanvasService) => {

				var CanV = await CanvasService.Update(id, request);
				return Results.Ok(CanV);
			});

			group.MapDelete("/{id:Guid}", async (Guid id, ICanvasService CanvasService) =>
			{
				var success = await CanvasService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});

		}
	}
}
