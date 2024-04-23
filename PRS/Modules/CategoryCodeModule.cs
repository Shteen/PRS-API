using PRS.Core.Models.Request;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules
{
    public static class CategoryCodeModule
	{
		public static async void AddCategoryCodeEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/CategoryCode");

			group.MapGet("/", async (ICategoryCodeService categorycodeService) => Results.Ok(await categorycodeService.GetAll()));

			group.MapGet("/{id:Guid}", async (Guid id, ICategoryCodeService categorycodeService) => {

				var categoryCode = await categorycodeService.GetById(id);

				if (categoryCode == null) return Results.NotFound();

				return Results.Ok(categoryCode);
			});
			

			group.MapPost("/", async (CategoryCodeRequest request, ICategoryCodeService categorycodeService) =>
			{
				var newcategoryCode = await categorycodeService.Create(request);
				return Results.Created($"api/CategoryCode/{newcategoryCode.Id}", newcategoryCode);
			});
			group.MapPut("/{id:Guid}", async (Guid id, CategoryCodeRequest request, ICategoryCodeService categorycodeService) => {

				var categoryCode = await categorycodeService.Update(id, request);
				return Results.Ok(categoryCode);
			});
			group.MapDelete("/{id:Guid}", async (Guid id, ICategoryCodeService categorycodeService) =>
			{
				var success = await categorycodeService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});


		}
	}
}
