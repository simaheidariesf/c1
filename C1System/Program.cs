using C1System.DataLayar.Context;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using C1System.Core.Services;
using C1System.Core.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("C1System");
builder.Services.AddDbContext<C1SystemContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddTransient<ISliderService, SliderService>();

var connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<C1SystemContext>(options => options.UseSqlServer(connectionStrings));

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
