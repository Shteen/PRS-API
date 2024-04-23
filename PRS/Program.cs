using PRS.Modules;
using PRS.DATA;
using PRS.SERVICE;
using PRS.Modules.Users;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using PRS.Modules.Supplier;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddLogging();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo { Title = "AngularAPI", Version = "v1" });
	// Add JWT bearer authentication
	var securityScheme = new OpenApiSecurityScheme
	{
		Name = "Authorization",
		BearerFormat = "JWT",
		Scheme = "bearer",
		Description = "Specify the authorization token.",
		In = ParameterLocation.Header,
		Type = SecuritySchemeType.Http,
	};

	c.AddSecurityDefinition("Bearer", securityScheme);

	var securityRequirement = new OpenApiSecurityRequirement
		{
			{
				new OpenApiSecurityScheme
				{
					Reference = new OpenApiReference
					{
						Type = ReferenceType.SecurityScheme,
						Id = "Bearer"
					}
				},
				new string[] { }
			}
		};

	c.AddSecurityRequirement(securityRequirement);
});

builder.Services.AddCors(opt =>
{
	opt.AddPolicy(name: "CorsPolicy", builder =>
	{
		builder
		.AllowAnyHeader()
		.AllowAnyMethod()
		.AllowAnyOrigin();

	});
});

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
	options.Cookie.Name = "Test_Cookie";
	options.IdleTimeout = TimeSpan.FromMinutes(30);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;
});

var configuration = builder.Configuration;

builder.Services
	.PRSData(configuration)
	.PRSService();


builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddJwtBearer(options =>
	{
		options.RequireHttpsMetadata = false;
		options.SaveToken = true;
		options.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateActor = true,
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ValidateIssuerSigningKey = true,
			ValidIssuer = builder.Configuration["Jwt:Issuer"],
			ValidAudience = builder.Configuration["Jwt:Audience"],
			IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("b259c9a6f7b4dc09e5e36169f3e46c35e7dc776a10a14b609fc29e6eefb125c2")),
		};
	});
var app = builder.Build();
app.UseCors("CorsPolicy");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(c =>
	{
		c.SwaggerEndpoint("/swagger/v1/swagger.json", "HRISAPI");

	});
}

app.UseAuthentication();
app.UseAuthorization();
app.AddCanvasEndpoints();
app.AddCategoryCodeEndpoints();
app.AddCategoryEndpoints();
app.UseHttpsRedirection();
app.AddRawMaterialEndpoints();
app.AddRawMatInventoryEndpoints();
app.AddPurchaseOrderEndpoints();
app.AddRecivingReportEndpoints();
app.AddUsersEndpoints();
app.AddSupplierEndpoints();
app.AddItemsWEndpoints();
app.AdBrandEndpoints();
app.Run();

