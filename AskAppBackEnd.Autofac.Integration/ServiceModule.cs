using Autofac;
using System.Linq;

namespace AskAppBackEnd.Autofac.Integration
{
    public class ServiceModule : Module
    {
       protected override void Load(ContainerBuilder builder)
        {

            var dataAccess = System.Reflection.Assembly.Load("AskAppBackEnd.Service");

            builder.RegisterAssemblyTypes(dataAccess)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces();
        }
    }
}
