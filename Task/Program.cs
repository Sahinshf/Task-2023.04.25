using Microsoft.EntityFrameworkCore;
using Task.Contexts;

var builder = WebApplication.CreateBuilder(args);

// We indicate that we use DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    // We specify which sql we are using
    options.UseSqlServer("Server=SHAHIN;Database=Pronia;Trusted_Connection=True;");
});

// Service
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Middleware

// Using static file ( index.html )
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
