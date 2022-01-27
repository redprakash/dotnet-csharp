global using WooliesX.OnBoarding.SuperHero.WebApi.Data;
global using Microsoft.EntityFrameworkCore;
using WooliesX.OnBoarding.SuperHero.WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<SuperHeroesDatabaseSettings>(
    builder.Configuration.GetSection("SuperHeroesDatabaseSettings"));
builder.Services.AddSingleton<SuperHeroService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
