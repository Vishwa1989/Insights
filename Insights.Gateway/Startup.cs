using Insights.Gateway.Repositories;
using Insights.Gateway.Services;
using Insights.Repository.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Versioning;
public class Startup
{
    public IConfiguration Configuration { get; }

    /// <summary>
    /// Initializes a new instance of the Startup class.
    /// </summary>
    /// <param name="configuration">Application configuration instance</param>
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    /// <summary>
    /// Configures the application services.
    /// This method gets called by the runtime. Use this method to add services to the container.
    /// </summary>
    /// <param name="services">The service collection to configure</param>
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddHealthChecks();
        RegisterServiceDependencies(services);
        // Add API versioning
        services.AddApiVersioning(options =>
        {
            options.ReportApiVersions = true;
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.DefaultApiVersion = new ApiVersion(1, 0);
        });
    }

    /// <summary>
    /// Registers service dependencies for dependency injection.
    /// Configures scoped services for Ad Insights functionality.
    /// </summary>
    /// <param name="services">The service collection to add dependencies to</param>
    private void RegisterServiceDependencies(IServiceCollection services)
    {
        // Register IAdInsightsService and its implementation
        services.AddScoped<IAdInsightsService, AdInsightsService>();

        // Register IAdInsightsRepository and its implementation
        services.AddScoped<IAdInsightsRepository, AdInsightsRepository>();
    }

    /// <summary>
    /// Configures the HTTP request pipeline.
    /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    /// </summary>
    /// <param name="app">The application builder</param>
    /// <param name="env">The web hosting environment</param>
    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Insights.Gateway API. v1");
                options.RoutePrefix = "docs";
            });
        }

        app.UseRouting();
        app.UseHealthChecks("/health");
        app.UseCors(); 
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}