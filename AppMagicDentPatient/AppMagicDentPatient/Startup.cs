using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMagicDentPatient.Startup))]
namespace AppMagicDentPatient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
