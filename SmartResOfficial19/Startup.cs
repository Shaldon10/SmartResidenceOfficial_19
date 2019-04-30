using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartResOfficial19.Startup))]
namespace SmartResOfficial19
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
