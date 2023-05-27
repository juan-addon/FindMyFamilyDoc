using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.Business;
using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Business.Services;
using FindMyFamilyDoc.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IDataService, DataService>();
builder.Services.AddScoped<IUserRefreshTokenService, UserRefreshTokenService>();
builder.Services.AddScoped<ApiKeyAuthFilter>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<DatabaseContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(opts =>
{
    opts.SignIn.RequireConfirmedEmail = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Find My Family Doc",
        Description = "Capstone 2023, FindMyFamilyDoc Application"
    });
});
JwtAuthenticationHelper.ConfigureJwtAuthentication(builder.Services, builder.Configuration);
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

/*app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});*/

app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
