using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GruppK.Startup))]
namespace GruppK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
