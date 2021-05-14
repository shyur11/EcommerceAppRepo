using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcommerceApp.WebUI.Startup))]
namespace EcommerceApp.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
