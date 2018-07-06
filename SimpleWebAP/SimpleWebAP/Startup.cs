using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleWebAP.Startup))]
namespace SimpleWebAP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
