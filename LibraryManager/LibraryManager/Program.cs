using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Catalog;
using DataAccessLayer.Repository;
using BusinessObjects.Entity;

internal class Program
{
    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder();

        var host = CreateHostBuilder(configuration).Build();
        ICatalogService apiCaller = host.Services.GetRequiredService<ICatalogService>();
        apiCaller.ShowCatalog();

    }

    private static IHostBuilder CreateHostBuilder(IConfigurationBuilder configuration)
    {
        
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddScoped<ICatalogService, CatalogService>();
                services.AddScoped<ICatalogManager, CatalogManager>();
                services.AddScoped<IGenericRepository<Author>, AuthorRepository>();
                services.AddScoped<IGenericRepository<Book>, BookRepository>();
                services.AddScoped<IGenericRepository<Library>, LibraryRepository>();
                services.AddDbContext<LibraryContext>(options =>
                    options.UseSqlite("Data Source=C:\\Users\\Marin\\Documents\\Github\\library-net\\ressources\\library.db;"));

            });
    }
}