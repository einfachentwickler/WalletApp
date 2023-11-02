using DataAccess.WallerAppDbContext;
using Microsoft.EntityFrameworkCore;

namespace WebApi.ServicesExtensions;

public static class ServicesExtensions
{
    public static void ConfigureDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<WalletAppDbContext>(options => options.UseNpgsql(configuration.GetSection("DbSettings:ConnectionString").Value, sqlOptions => sqlOptions.MigrationsAssembly("DataAccess")));
    }
}