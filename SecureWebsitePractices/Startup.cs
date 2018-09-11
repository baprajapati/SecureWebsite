using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecureWebsitePractices.Startup))]
namespace SecureWebsitePractices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
