using MongoDB.Driver;
using Repositories.MongoModels;

namespace MainApi.Extensions;

public static class ServicesExtensions
{
    public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var dbConnString = configuration.GetSection("DBCONNSTRING").Value ?? string.Empty;

        services.AddSingleton(typeof(IMongoClient), new MongoClient(dbConnString));
        services.AddSingleton(typeof(IMongoDatabase), x =>
        {
            var client = x.GetRequiredService<IMongoClient>();
            return client.GetDatabase("Db");
        });

        services.AddSingleton(typeof(IMongoCollection<Content>), x =>
        {
            var database = x.GetRequiredService<IMongoDatabase>();
            return database.GetCollection<Content>("WebsiteContent");
        });

        services.AddSingleton(typeof(IMongoCollection<Weather>), x =>
        {
            var database = x.GetRequiredService<IMongoDatabase>();
            return database.GetCollection<Weather>("Weather");
        });
    }
}