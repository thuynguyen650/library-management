using LibraryManagement.Infrastructure;
using LibraryManagement.Application;
using System.Runtime.CompilerServices;
using LibraryManagement.Infrastructure.Persistence;
using LibraryManagement.Application.Contracts.Persistence;
using LibraryManagement.Infrastructure.Persistence.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(
                name: "OpenCORSPolicy",
                builder =>
                {
                    builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
                });
        });

        builder.Services.AddInfrastructure(builder.Configuration);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        // Add Swagger
        builder.Services.AddSwaggerGen();

        // Add Application
        builder.Services.AddApplication(builder.Configuration);

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

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
        app.UseCors("OpenCORSPolicy");
        app.UseAuthentication();
        app.UseAuthorization();

        DataSeeder.Seed(app);

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}