﻿using SIS.MvcFramework.DependencyContainer;
using SIS.MvcFramework.Routing;

namespace SIS.MvcFramework
{
    public interface IMvcApplication
    {
        void Configure(IServerRoutingTable serverRoutingTable);

        void ConfugureServices(IServiceProvider  serviceProvider); //For DI
    }
}
