using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SheresPlace.WebUI.Startup))]
namespace SheresPlace.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
