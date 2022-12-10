using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcsWeb.Startup))]
namespace AcsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
