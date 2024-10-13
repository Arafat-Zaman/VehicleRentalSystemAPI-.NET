using VehicleRentalSystemAPI.Data;
using VehicleRentalSystemAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using VehicleRentalSystemAPI.Data;
using VehicleRentalSystemAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddDbContext<VehicleDbContext>(options =>
    options.UseInMemoryDatabase("VehicleRentalDB"));
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddControllers();

// Add services to the container.

builder.Services.AddControllers();
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
