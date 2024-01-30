// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Services.Services; 

internal class Program
{
    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder();

        var host = CreateHostBuilder(configuration).Build();
        ICatalogService apiCaller = host.Services.GetRequiredService<ICatalogService>();
        apiCaller.ShowCatalog();


        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(IConfigurationBuilder configuration)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                
            });
    }
}