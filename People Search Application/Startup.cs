using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(People_Search_Application.Startup))]
namespace People_Search_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
