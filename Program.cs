using System;
using System.Windows.Forms;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using RecordedMusicCatalogue.UI;

namespace RecordedMusicCatalogue
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ServiceCollection services = ConfigureServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            var startForm = serviceProvider.GetRequiredService<RecordedMusicCatalogueForm>();

            Application.Run(startForm);
        }

        static ServiceCollection ConfigureServices()
        {
            ServiceCollection services = new();

            services.AddTransient<IVinylRecordRepository>(_ => new VinylRecordRepository());
            services.AddTransient<ITracksRepository>(_ => new TracksRepository());
            services.AddTransient<ICassetteRepository>(_ => new CassetteRepository());
            services.AddTransient<ICdRepository>(_ => new CdRepository());

            services.AddTransient<RecordedMusicCatalogueForm>();
            services.AddTransient<VinylRecordCollection>();
            services.AddTransient<CassetteCollectionForm>();
            services.AddTransient<CDCollectionForm>();
            services.AddTransient<TracksForm>();
                  
            return services;
        }
    }
}