using FindMyFamilyDoc.API;
using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.API.Helpers;
using FindMyFamilyDoc.API.Interfaces;
using FindMyFamilyDoc.API.Models;
using FindMyFamilyDoc.API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
JwtAuthenticationHelper.ConfigureJwtAuthentication(builder.Services, builder.Configuration);
builder.Services.AddAuthorization();

builder.Services.AddControllers(x => x.Filters.Add<ApiKeyAuthFilter>());

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<DatabaseContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(opts =>
{
    opts.SignIn.RequireConfirmedEmail = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseMiddleware<ApiKeyAuthMiddleware>();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
