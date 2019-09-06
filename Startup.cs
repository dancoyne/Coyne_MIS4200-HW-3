using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coyne_MIS4200.Startup))]
namespace Coyne_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
