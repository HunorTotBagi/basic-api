using Microsoft.EntityFrameworkCore;
using Zoo.DbContexts;
using Zoo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AnimalContext>(
    options => options.UseSqlite("Data Source=Animal.db"));

builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();