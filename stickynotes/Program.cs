using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using stickynotes.Data;
namespace stickynotes;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<stickynotesContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("stickynotesContext") ?? throw new InvalidOperationException("Connection string 'stickynotesContext' not found.")));

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
            pattern: "{controller=Home}/{action=Main}/{id?}");

        app.Run();
    }
}

