using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CineRent.Startup))]
namespace CineRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
