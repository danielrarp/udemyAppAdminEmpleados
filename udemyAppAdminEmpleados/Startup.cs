using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(udemyAppAdminEmpleados.Startup))]
namespace udemyAppAdminEmpleados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
