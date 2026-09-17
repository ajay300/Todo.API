using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Persistence.Entities;

namespace Todo.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            var confirugrationString = configuration.GetConnectionString("Default");

            services.AddDbContext<TodoAppDbcontext>(options => options.UseSqlServer(confirugrationString));

            return services;
        } 

    }
}
