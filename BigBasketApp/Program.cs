using System;
using Microsoft.EntityFrameworkCore;
using BigBasketApp.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<UserContext>(options =>options.UseNpgsql("Server=localhost;port=5432;Database=BigBasketDB;user id=postgres;password=postgres"));
builder.Services.AddDbContext<ItemsContext>(options=>options.UseNpgsql("Server=localhost;port=5432;Database=BigBasketDB;user id=postgres;password=postgres"));
builder.Services.AddAuthorization();

//add db contexts

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


app.Run();

