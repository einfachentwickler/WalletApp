using System.Text.Json.Serialization;
using WebApi.Configuration;
using WebApi.Middleware;
using WebApi.ServicesExtensions;

namespace WebApi;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        builder.Services.ConfigureDataAccess(builder.Configuration);

        builder.Services.RegisterDependencies();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services
            .AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

        builder.Services.AddAutoMapper(typeof(MappingProfile));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseMiddleware<ExceptionHandlerMiddleware>();

        app.MapControllers();

        app.UseRouting();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();
    }
}