using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Café.Startup))]
namespace Café
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
