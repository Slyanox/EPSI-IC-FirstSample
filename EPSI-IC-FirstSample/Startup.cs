using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPSI_IC_FirstSample.Startup))]
namespace EPSI_IC_FirstSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
