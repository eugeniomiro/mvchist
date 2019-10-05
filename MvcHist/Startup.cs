using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcHist.Startup))]
namespace MvcHist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
