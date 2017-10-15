using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fintastic.Startup))]
namespace Fintastic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
