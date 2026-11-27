using Microsoft.EntityFrameworkCore;
using NMagazine.Core.Models;
using NMagazine.Data.Contexts;
using NMagazine.Data.Contexts;
using NMagazine.Data.Repositories.Implements;
using NMagazine.Data.Repositories.Interfaces;
using NMagazine.Service.Services.Implements;
using NMagazine.Service.Services.Interfaces;
using NMagazine.Service.Services.Implements;
using NMagazine.Service.Services.Interfaces;
using NVShop.Data.Repositories.Interfaces;
using NVShop.Service.Services.implements;
using NVShop.Service.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Repository
builder.Services.AddScoped<IGenericRepository<Category>, GenericRepository<Category>>();
builder.Services.AddScoped<IGenericRepository<Product>, GenericRepository<Product>>();

//Services
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddDbContext<AppDbContext>(opt =>
opt.UseNpgsql(builder.Configuration.GetConnectionString("Default"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
