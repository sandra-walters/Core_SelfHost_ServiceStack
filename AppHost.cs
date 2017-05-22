using System;
using System.Reflection;
using ServiceStack;

namespace Core_SelfHost_ServiceStack
{
    public class AppHost : AppHostBase
    {
        public AppHost()
          : base(".NET Core Self-Host", typeof(AppHost).GetTypeInfo().Assembly) { }

        public override void Configure(Funq.Container container) 
        {
            Routes.Add<HelloRequest>("/hello/{Name}");
            Routes.Add<PingRequest>("/ping");
        }
    }
}