using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HROilCompany.Startup))]
namespace HROilCompany
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
