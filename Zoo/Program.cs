using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Zoo.DbContexts;
using Zoo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// First addition
builder.Services.AddDbContext<AnimalContext>(
    options => options.UseSqlite("Data Source=Animal.db"));
// First addition

// Second addition
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
// Second addition


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
