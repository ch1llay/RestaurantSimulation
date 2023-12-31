using DataAccess;
using DataAccess.DataContexts;
using DataAccess.DataContexts.Interfaces;
using DataAccess.DI;
using DataAccess.DI.Interfaces;
using Domain.DI;
using Domain.DI.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using FluentMigrator.Runner;
using RestaurantSimulation;
using RestaurantSimulation.Middlwares;
using Service.DI;
using Service.DI.Interfaces;
using Service.Services;
using Service.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Configure();

builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();
app.ConfigureApp();

app.Run();


namespace RestaurantSimulation
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

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = string.Empty;
                });
            }
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

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
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
            services.AddScoped<IEmployeeDbService, EmployeeService>();
        }

        public static void AddScopedGroup(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDishRepository, DishRepository>();
            services.AddScoped<IDishRepository, DishRepository>();
        }

        public static void AddSingletonGroup(this IServiceCollection services)
        {
            services.AddSingleton<IDataContext, DapperContext>();
        }
    }
}