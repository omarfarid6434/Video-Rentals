using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Video_Rentals.Startup))]
namespace Video_Rentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
