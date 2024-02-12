using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using appleMusic.Data;
using appleMusic;
using appleMusic.Models;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();




CsvReader csvReader = new CsvReader();
string filePath = "apple_music_dataset.csv";

// Read 
List<Artist> artists = csvReader.Read<Artist>(filePath);
List<Collection> collections = csvReader.Read<Collection>(filePath);
List<Track> tracks = csvReader.Read<Track>(filePath);

app.Map("/artist", ctx =>
{
    ctx.Run(async context =>
    {
        await context.Response.WriteAsync(JsonSerializer.Serialize(artists));
    });
});

app.Map("/collections", ctx =>
{
    ctx.Run(async context =>
    {
        await context.Response.WriteAsync(JsonSerializer.Serialize(collections));
    });
});
app.Map("/tracks", ctx =>
{
    ctx.Run(async context =>
    {
        await context.Response.WriteAsync(JsonSerializer.Serialize(tracks));
    });
});







// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();
