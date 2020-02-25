using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgroApp.Startup))]
namespace AgroApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
