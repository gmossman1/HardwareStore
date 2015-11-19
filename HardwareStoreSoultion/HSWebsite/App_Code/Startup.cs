using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HSWebsite.Startup))]
namespace HSWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
