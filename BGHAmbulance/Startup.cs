using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BGHAmbulance.Startup))]
namespace BGHAmbulance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
