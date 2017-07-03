using Autofac;
using System.Linq;
//using System.Reflection;

namespace AskAppBackEnd.Autofac.Integration
{
    public class RepositoryModule : Module
    {   
        protected override void Load(ContainerBuilder builder)
        {
            var dataAccess = System.Reflection.Assembly.Load("AskAppBackEnd.Data");

            builder.RegisterAssemblyTypes(dataAccess)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces();
        }
    }
}
