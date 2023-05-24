using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eportafolio_2023.Startup))]
namespace eportafolio_2023
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
