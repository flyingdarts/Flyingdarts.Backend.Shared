public class HelperMethods
{
    public static IMediator BuildMediator()
    {
        var services = new ServiceCollection();

        services.AddSingleton<IDynamoDBContext>();
        services.AddSingleton(new ApplicationOptions { DynamoDbTable = "ApplicationTable" });
        services.AddSingleton<AmazonDynamoDBClient>();
        services.AddSingleton<DynamoDbService>();

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(typeof(CreateRoomCommand).Assembly);
        });

        var provider = services.BuildServiceProvider();

        return provider.GetRequiredService<IMediator>();
    }
}