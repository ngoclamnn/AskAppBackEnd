using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AskApp.Website.Startup))]
namespace AskApp.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
