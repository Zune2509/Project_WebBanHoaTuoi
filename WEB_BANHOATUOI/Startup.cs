using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEB_BANHOATUOI.Startup))]
namespace WEB_BANHOATUOI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
