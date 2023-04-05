using System.Reflection;
using Flyingdarts.Persistence;
using Microsoft.Extensions.DependencyInjection;
using ApplicationOptions = Flyingdarts.Shared.ApplicationOptions;

public class HelperMethods
{
    public static IMediator BuildMediator(Assembly assembly)
    {
        var services = new ServiceCollection();

        services.AddSingleton<IDynamoDBContext>();
        services.AddSingleton(new ApplicationOptions { DynamoDbTable = "ApplicationTable" });
        services.AddSingleton<AmazonDynamoDBClient>();
        services.AddSingleton<DynamoDbService>();

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(assembly);
        });

        var provider = services.BuildServiceProvider();

        return provider.GetRequiredService<IMediator>();
    }
}