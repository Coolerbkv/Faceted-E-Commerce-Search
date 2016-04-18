using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Faceted_E_Commerce_Search.Startup))]
namespace Faceted_E_Commerce_Search
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
