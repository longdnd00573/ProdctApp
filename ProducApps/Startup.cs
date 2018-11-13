using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProducApps.Startup))]
namespace ProducApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
