using Autofac;
using System.Linq;

namespace DiscountCrazyAdmin.Autofac.Integration
{
    public class ServiceModule : Module
    {
       protected override void Load(ContainerBuilder builder)
        {

            var dataAccess = System.Reflection.Assembly.Load("DiscountCrazyAdmin.Service");

            builder.RegisterAssemblyTypes(dataAccess)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces();
        }
    }
}
