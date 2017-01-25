using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KurumsalWebSitesi.Startup))]
namespace KurumsalWebSitesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
