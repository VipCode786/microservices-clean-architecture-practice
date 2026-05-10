
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using DataAccessLayer.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionStringTemplate = configuration.GetConnectionString("DefaultConnection")!;
            string connectionString = connectionStringTemplate
              .Replace("$host", Environment.GetEnvironmentVariable("host"))
              .Replace("$password", Environment.GetEnvironmentVariable("password"));

            services.AddDbContext<ApplicationDbContext>(
                options => 
                {
                    // options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")!);
                    options.UseSqlServer(connectionString);
                });
            services.AddScoped<IProductsRepository, ProductsRepository>();
            return services;
        }
    }
}
