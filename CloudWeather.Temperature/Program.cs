using CloudWeather.Temperature.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TemperatureDbContext>(options =>
{
    options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
    options.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
}, ServiceLifetime.Transient
);

var app = builder.Build();

app.Run();
