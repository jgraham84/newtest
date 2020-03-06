using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2020Partialview.Startup))]
namespace _2020Partialview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
