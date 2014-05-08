using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vsgithubsite.Startup))]
namespace vsgithubsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
