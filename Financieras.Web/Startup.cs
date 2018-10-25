using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Financieras.Web.Startup))]
namespace Financieras.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
