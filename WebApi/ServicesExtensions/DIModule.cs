using BusinessLogic.DailyPoints;
using BusinessLogic.Formatters;
using BusinessLogic.Formatters.Interfaces;
using BusinessLogic.Handlers.CardDetails;
using BusinessLogic.Handlers.Transactions;
using BusinessLogic.ImageProcessing;
using BusinessLogic.Providers;
using BusinessLogic.RandomNumberGenerator;
using DataAccess.Repositories;

namespace WebApi.ServicesExtensions;

public static class DIModule
{
    public static void RegisterDependencies(this IServiceCollection services)
    {
        services.AddScoped<ITransactionRepository, TransactionRepository>();

        services.AddScoped<ITransactionsHandler, TransactionsHandler>();
        services.AddScoped<ICardDetailsHandler, CardDetailsHandler>();
        services.AddScoped<IDateFormatter, DateFormatter>();
        services.AddScoped<ISystemClock, SystemClock>();
        services.AddScoped<IDailyPointsResolver, DailyPointsResolver>();
        services.AddScoped<IImageProcessor, ImageProcessor>();
        services.AddScoped<IBalanceGenerator, RandomNumberGenerator>();
        services.AddScoped<IDailyPointsFormatter, DailyPointsFormatter>();
    }
}