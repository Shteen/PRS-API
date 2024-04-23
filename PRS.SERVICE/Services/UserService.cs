using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PRS.Service.Services
{
    public class UserService : IUserService
	{
		
		
		
		private readonly OtherDbContext _context;

		private readonly IUserRepository _user;

		public UserService(OtherDbContext context, IUserRepository user)
		{
			
			
			
			_context = context;
			_user = user;
		}


		public async Task<List<UserResponse>> GetAll()
		{
			var users = await _user.GetAll();

			var userDto = users.Adapt<List<UserResponse>>();

			return userDto;
		}

		public async Task<LoginResponse> UserLogin(LoginRequest request)
		{
			var user = await _context.User.FirstOrDefaultAsync(x => x.EmployeeNumber == request.EmployeeNumber);

			// Check if the user exists
			if (user == null)
			{
				return null;
			}

			// Check if the Password column is NULL
			if (user.Password == null)
			{
				// Handle the case where the password is NULL (customize as needed)
				// For example, you might want to log this event or return an error response.
				return null;
			}

			// Verify the password using your PasswordHasher
			if (PasswordHasher.VerifyPassword(request.Password, user.Password))
			{
				var loginResponse = user.Adapt<LoginResponse>();

				// Check if the password is the temporary password
				loginResponse.IsTemporaryPassword = request.Password == "Temp_Password01";

				loginResponse.token = CreateJwt(user);

				return loginResponse;
			}

			// If the password verification fails
			return null;
		}


		//private static string CheckPasswordStrength(string pass)
		//{
		//	StringBuilder sb = new StringBuilder();
		//	if (pass.Length < 9)
		//		sb.Append("Minimum password length should be 8" + Environment.NewLine);
		//	if (!(Regex.IsMatch(pass, "[a-z]") && Regex.IsMatch(pass, "[A-Z]") && Regex.IsMatch(pass, "[0-9]")))
		//		sb.Append("Password should be AlphaNumeric" + Environment.NewLine);
		//	if (!Regex.IsMatch(pass, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\[,\\],{,},?,:,;,|,',\\,.,/,~,`,-,=]"))
		//		sb.Append("Password should contain special charcter" + Environment.NewLine);
		//	return sb.ToString();
		//}

		private string CreateJwt(User user)
		{
			var jwtTokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.ASCII.GetBytes("b259c9a6f7b4dc09e5e36169f3e46c35e7dc776a10a14b609fc29e6eefb125c2");
			var identity = new ClaimsIdentity(new Claim[]
			{
				 new Claim(ClaimTypes.Name, user.EmployeeNumber.ToString()),
				 new Claim(ClaimTypes.Role, user.userType)
			});

			var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);
			var issuer_audience = "http//localhost:5041/";
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = identity,
				Expires = DateTime.Now.AddDays(1),
				SigningCredentials = credentials,
				Issuer = issuer_audience,
				Audience = issuer_audience,

			};
			var token = jwtTokenHandler.CreateToken(tokenDescriptor);
			return jwtTokenHandler.WriteToken(token);
		}
	}
}
