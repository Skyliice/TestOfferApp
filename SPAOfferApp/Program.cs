using Microsoft.EntityFrameworkCore;
using SPA_Offer_App.Interfaces;
using SPA_Offer_App.Models;
using SPA_Offer_App.Repositories;
using SPA_Offer_App.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Offersdb;Trusted_Connection=True;"));
builder.Services.AddTransient<IOfferConnection, OfferDbRepository>();
builder.Services.AddTransient<OfferService>();
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();