using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudoGit.Startup))]
namespace EstudoGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
