using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modulo1.Startup))]
namespace Modulo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
