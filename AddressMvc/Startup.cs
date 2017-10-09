using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddressMvc.Startup))]
namespace AddressMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
