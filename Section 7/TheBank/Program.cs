using Microsoft.EntityFrameworkCore;
using TheBank.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BankAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankAppDbContext") ?? throw new InvalidOperationException("Connection string 'BankAppContext' not found.")));

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
