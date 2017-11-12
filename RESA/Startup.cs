using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RESA.Startup))]
namespace RESA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
