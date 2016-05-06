using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstGit.Startup))]
namespace MyFirstGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
