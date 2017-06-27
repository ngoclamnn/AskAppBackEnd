using Autofac;
using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data;
using System.Data.Entity;

namespace DiscountCrazyAdmin.Autofac.Integration
{

    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DiscountCrazyAdminContext>().As<DbContext>();
            builder.RegisterType<DiscountCrazyAdminUnitOfWork>().As<IUnitOfWork>();
        }
    }
}
