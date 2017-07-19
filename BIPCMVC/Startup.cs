using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BIPCMVC.Startup))]
namespace BIPCMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
