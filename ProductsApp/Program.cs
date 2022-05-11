using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductsApp.Models;
using ProductsApp.Data;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

//add this for the connection string and Dependency Injection (DM3):
builder.Services.AddDbContext<WProductsDBContext>(options =>
options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnection")

    , sqlServerOptionsAction: sqlOptions =>
     {
         sqlOptions.EnableRetryOnFailure();
     }



));
// options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));


// Add services to the container.
builder.Services.AddControllersWithViews();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
