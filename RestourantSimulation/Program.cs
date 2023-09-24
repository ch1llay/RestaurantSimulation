using DataAccess;
using DataAccess.Interfaces;
using Domain;
using Domain.Interfaces;
using FluentMigrator.Runner;
using RestourantSimulation.Middlwares;
using Service;
using Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Configure();

builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();

app.Run();


public static class Extensions
{
    public static void AddMigrations(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var migrator = scope.ServiceProvider.GetService<IMigrationRunner>();
        migrator?.MigrateUp();
    }

    public static void ConfigureApp(this WebApplication app)
    {
        app.UseMiddleware<GlobalExceptionMiddleware>();
        app.UseRouting();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        app.AddMigrations();
    }

    public static void ConfigureMigrator(this IMigrationRunnerBuilder migrationRunnerBuilder, ConfigurationManager config)
    {
        DbFactory.GetMigrationSetuper(config, migrationRunnerBuilder)(migrationRunnerBuilder);
    }

    public static void Configure(this WebApplicationBuilder builder)
    {
        builder.Configuration.AddJsonFile("appsettings.json");

        builder.Services.AddFluentMigratorCore()
            .ConfigureRunner(c => c.ConfigureMigrator(builder.Configuration))
            .AddLogging();

        builder.Services.AddTransientGroup();
        builder.Services.AddScopedGroup();
        builder.Services.AddSingletonGroup();
        builder.Services.AddControllers();
    }

    public static void AddTransientGroup(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IProductService, ProductService>();
    }

    public static void AddScopedGroup(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICookingDishRepository, CookingDishRepository>();
        services.AddScoped<IDishRepository, DishRepository>();
        services.AddScoped<IDishRepository, DishRepository>();
    }

    public static void AddSingletonGroup(this IServiceCollection services)
    {
        services.AddSingleton<IDataContext, DapperContext>();
    }
}