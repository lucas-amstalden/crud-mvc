using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeiroCrudMVC.Startup))]
namespace PrimeiroCrudMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
