using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AVagas.Startup))]
namespace AVagas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
