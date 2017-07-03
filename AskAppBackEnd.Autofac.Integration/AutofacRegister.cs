using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Autofac.Integration
{
    public static class AutofacRegister
    {
        public static ContainerBuilder Setup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new CoreModule());

            return builder;
        }
    }
}
