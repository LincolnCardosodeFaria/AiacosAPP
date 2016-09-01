using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aiacos.Startup))]
namespace Aiacos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
