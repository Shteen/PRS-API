using PRS.CORE.Interfaces.Services;
using PRS.Core.Models.Request;
using PRS.Core.Entites;

namespace PRS.Modules
{
	public static class BrandModule
	{


		public static async void AdBrandEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/Brand");

			group.MapGet("/", async (IBrandService BrandService) => Results.Ok(await BrandService.GetAll()));

			group.MapGet("/{id:Guid}", async (Guid id, IBrandService BrandService) => {

				var brnd = await BrandService.GetById(id);

				if (brnd == null) return Results.NotFound();

				return Results.Ok(brnd);
			});

			group.MapGet("/search", async (string search, IBrandService BrandService, int page) => {

				var employeeDetails = await BrandService.GetBySearch(search, page);
				return Results.Ok(employeeDetails);


			});



			group.MapPost("/", async (BrandRequest request, IBrandService BrandService) =>
			{
				var newbrnd = await BrandService.Create(request);
				return Results.Created($"api/Brand/{newbrnd.Id}", newbrnd);
			});

			group.MapPut("/{id:Guid}", async (Guid id, BrandRequest request, IBrandService BrandService) => {

				var brnd = await BrandService.Update(id, request);
				return Results.Ok(brnd);
			});

			group.MapDelete("/{id:Guid}", async (Guid id, IBrandService BrandService) =>
			{
				var success = await BrandService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});

		}

	}
}
