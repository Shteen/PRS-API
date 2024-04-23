using PRS.Core.Models.Request;
using Microsoft.AspNetCore.Authorization;
using PRS.CORE.Interfaces.Services;

namespace PRS.Modules.Users
{
    public static class UserModule
	{

		public static async void AddUsersEndpoints(this IEndpointRouteBuilder app)
		{
			var group = app.MapGroup("/api/Users");

			group.MapGet("/", async (IUserService userService) => Results.Ok(await userService.GetAll()));

			group.MapPost("login", async (LoginRequest request, IUserService usersService) =>
			{
				var loginResponse = await usersService.UserLogin(request);

				if (loginResponse == null)
				{
					return Results.BadRequest("Invalid Account");
				}

				if (loginResponse != null)
				{
					return Results.Ok(loginResponse);
				}
				else
				{
					return Results.BadRequest("Incorrect password");
				}
			});
		}
	}
}
