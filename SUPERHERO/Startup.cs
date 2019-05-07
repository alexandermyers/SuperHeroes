using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SUPERHERO.Startup))]
namespace SUPERHERO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
