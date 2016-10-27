using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoAspa.Startup))]
namespace ProyectoAspa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
