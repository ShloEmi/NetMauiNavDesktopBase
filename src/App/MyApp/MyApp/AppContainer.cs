using Autofac;
using Microsoft.Extensions.Configuration;

public static class AppContainer
{
    public static Autofac.IContainer Container { get; private set; }

    public static void ConfigureServices(IConfiguration configuration)
    {
        var builder = new ContainerBuilder();

        // Register your services here

        Container = builder.Build();
    }
}
