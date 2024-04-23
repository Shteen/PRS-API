using PRS.Core.Models.Request;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules
{
    public static class CategoryModule
	{
		public static async void AddCategoryEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/Category");

			group.MapGet("/", async (ICategoryService categoryService) => Results.Ok(await categoryService.GetAll()));

			group.MapGet("/{id:Guid}", async (Guid id, ICategoryService categoryService) => {

				var category = await categoryService.GetById(id);

				if (category == null) return Results.NotFound();

				return Results.Ok(category);
			});
			
			

			group.MapPost("/", async (CategoryRequest request, ICategoryService categoryService) =>
			{
				var newcategory = await categoryService.Create(request);
				return Results.Created($"api/Branch/{newcategory.id}", newcategory);
			});

			group.MapPut("/{id:Guid}", async (Guid id, CategoryRequest request, ICategoryService categoryService) => {

				var category = await categoryService.Update(id, request);
				return Results.Ok(category);
			});

			group.MapDelete("/{id:Guid}", async (Guid id, ICategoryService categoryService) =>
			{
				var success = await categoryService.Delete(id);

				return !success ? Results.NotFound() : Results.NoContent();
			});


		}
	}
}
