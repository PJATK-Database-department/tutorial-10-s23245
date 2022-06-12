



using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using task10_apbd.Data;
namespace task10_apbd;

public class Startup
{

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<task10_apbdContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("task10_apbdContext") ?? throw new InvalidOperationException("Connection string 'task10_apbdContext' not found.")));
        // Add services to the container.
        services.AddControllersWithViews();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configure the HTTP request pipeline.
        if (env.IsDevelopment())
        {
            app.UseExceptionHandler("/HelloWorld/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movie}/{action=Index}/{id?}");
        });

        
        
    }
    
    

    

}