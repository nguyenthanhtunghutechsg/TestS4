using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoGit.Startup))]
namespace DemoGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
