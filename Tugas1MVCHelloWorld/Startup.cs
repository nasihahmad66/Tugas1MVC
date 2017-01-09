using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tugas1MVCHelloWorld.Startup))]
namespace Tugas1MVCHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
