using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CDN.API.Data;
using CDN.API.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CDNAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CDNAPIContext") ?? throw new InvalidOperationException("Connection string 'CDNAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews(); // Add support for controllers and views
builder.Services.AddScoped<UsersAPIController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(); // Necessary to serve static files like CSS, images, and JavaScript

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();  // Map attribute-routed API controllers
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");
});

app.Run();
