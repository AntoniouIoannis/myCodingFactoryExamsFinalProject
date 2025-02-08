using CultureGR_MVC_ModelFirst.Configuration;
using CultureGR_MVC_ModelFirst.Data;
using CultureGR_MVC_ModelFirst.Repositories;
using CultureGR_MVC_ModelFirst.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace CultureGR_MVC_ModelFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<CultureGRDBContext>(options => options.UseSqlServer(connString));
            builder.Services.AddRepositories();

            builder.Host.UseSerilog((context, config) =>
            {
                config.ReadFrom.Configuration(context.Configuration);
            });

            builder.Services.AddAutoMapper(typeof(MapperConfig));

            builder.Services.AddRepositories();
            builder.Services.AddScoped<IApplicationService, ApplicationService>();
            builder.Services.AddScoped<ISubscriberService, SubscriberService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = "/CultureGRUser/Login";
                    option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios,
                // see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",    //  starting web page
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
