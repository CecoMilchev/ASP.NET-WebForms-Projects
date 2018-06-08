using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryOrganizer.Startup))]
namespace LibraryOrganizer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
