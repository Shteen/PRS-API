using PRS.Core.Models.Request;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules
{
    public static class RecivingReportModule
	{

		public static async void AddRecivingReportEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/RecivingReport");

			group.MapGet("/", async (IRecivingReportService RecivingReportService) => Results.Ok(await RecivingReportService.GetAll()));

			group.MapGet("/{id:Guid}", async (Guid id, IRecivingReportService RecivingReportService) => {

				var RecRepp = await RecivingReportService.GetById(id);

				if (RecRepp == null) return Results.NotFound();

				return Results.Ok(RecRepp);
			});



			group.MapPost("/", async (RecivingReportRequest request, IRecivingReportService RecivingReportService) =>
			{
				var newRecRepp = await RecivingReportService.Create(request);
				return Results.Created($"api/Branch/{newRecRepp.Id}", newRecRepp);
			});

			group.MapPut("/{id:Guid}", async (Guid id, RecivingReportRequest request, IRecivingReportService RecivingReportService) => {

				var RecRepp = await RecivingReportService.Update(id, request);
				return Results.Ok(RecRepp);
			});

			group.MapDelete("/{id:Guid}", async (Guid id, IRecivingReportService RecivingReportService) =>
			{
				var success = await RecivingReportService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});


		}

	}
}
