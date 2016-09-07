using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingTeamcity.Startup))]
namespace TestingTeamcity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
