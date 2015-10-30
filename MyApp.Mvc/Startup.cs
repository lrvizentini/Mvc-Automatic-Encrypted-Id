using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyApp.Mvc.Startup))]
namespace MyApp.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
