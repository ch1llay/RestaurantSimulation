using DataAccess;
using DataAccess.DI;
using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.DI;
using Domain.DI.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using FluentMigrator.Runner;
using RestourantSimulation;
using RestourantSimulation.Middlwares;
using Service.DI.Interfaces;
using Service.Services;
using Service.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Configure();

builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();
app.ConfigureApp();

app.Run();


namespace RestourantSimulation
{
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

            builder.ConfigureService();
            builder.Services.AddControllers();
            builder.Services.AddAutoMapper(typeof(AppMappingProfile));
        }

        public static void ConfigureServiceStandart(WebApplicationBuilder builder)
        {
            builder.Services.AddTransientGroup();
            builder.Services.AddScopedGroup();
            builder.Services.AddSingletonGroup();
        }

        public static void ConfigureService(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
            builder.Services.AddScoped<IServiceManager, ServiceManager>();
            builder.Services.AddSingleton<IDataContextManager, DataContextManager>();
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
}