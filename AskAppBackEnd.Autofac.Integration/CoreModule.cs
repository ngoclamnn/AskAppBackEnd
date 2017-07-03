using Autofac;
using AskAppBackEnd.Core;
using AskAppBackEnd.Data;
using System.Data.Entity;

namespace AskAppBackEnd.Autofac.Integration
{

    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AskAppContext>().As<DbContext>();
            builder.RegisterType<AskAppUnitOfWork>().As<IUnitOfWork>();
        }
    }
}
