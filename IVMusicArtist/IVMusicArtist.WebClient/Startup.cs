using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IVMusicArtist.WebClient.Startup))]
namespace IVMusicArtist.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
