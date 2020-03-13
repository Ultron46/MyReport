using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Training_TFS.Startup))]
namespace Training_TFS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
