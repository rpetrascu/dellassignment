using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dell.Startup))]
namespace Dell
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
