using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocBase.Startup))]
namespace DocBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
