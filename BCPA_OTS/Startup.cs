using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BCPA_OTS.Startup))]
namespace BCPA_OTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
