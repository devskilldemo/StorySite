using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SotreSite.Startup))]
namespace SotreSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
