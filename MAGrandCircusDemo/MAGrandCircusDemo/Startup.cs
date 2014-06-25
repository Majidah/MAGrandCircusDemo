using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MAGrandCircusDemo.Startup))]
namespace MAGrandCircusDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
