using IRunes.Data;
using IRunes.Services;
using SIS.MvcFramework;
using SIS.MvcFramework.DependencyContainer;
using SIS.WebServer.Routing;

namespace IRunes.App
{
    public class Startup : IMvcApplication
    {
        public void Configure(IServerRoutingTable serverRoutingTable)
        {
            using (var context = new RunesDbContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public void ConfugureServices(IServiceProvider serviceProvider)
        {
            serviceProvider.Add<IAlbumService, AlbumService>();
            serviceProvider.Add<ITrackService, TrackService>();
            serviceProvider.Add<IUserService, UserService>();
        }
    }
}