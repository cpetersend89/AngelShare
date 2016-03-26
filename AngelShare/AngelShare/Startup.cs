using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngelShare.Startup))]
namespace AngelShare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
