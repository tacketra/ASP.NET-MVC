using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W3SchoolsWebApp.Startup))]
namespace W3SchoolsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
