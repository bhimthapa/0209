using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApi.Web.Startup))]
namespace WebApi.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
