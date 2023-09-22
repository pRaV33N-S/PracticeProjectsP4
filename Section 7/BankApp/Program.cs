using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BankApp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BankAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankAppContext") ?? throw new InvalidOperationException("Connection string 'BankAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
