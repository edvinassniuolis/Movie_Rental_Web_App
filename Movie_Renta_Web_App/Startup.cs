using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movie_Renta_Web_App.Startup))]
namespace Movie_Renta_Web_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
