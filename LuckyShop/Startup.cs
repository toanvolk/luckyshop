using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuckyShop.Startup))]
namespace LuckyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
