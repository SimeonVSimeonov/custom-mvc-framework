using SIS.MvcFramework;
using SIS.MvcFramework.Routing;
using SIS.MvcFramework.DependencyContainer;
using Musaca.Data;

namespace Musaca.App
{
    public class StartUp : IMvcApplication
    {
        public void Configure(IServerRoutingTable serverRoutingTable)
        {
            using (var context = new MusacaDbContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public void ConfugureServices(IServiceProvider serviceProvider)
        {
            
        }
    }
}