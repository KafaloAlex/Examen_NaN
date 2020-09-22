using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Andrea.Startup))]
namespace Andrea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
