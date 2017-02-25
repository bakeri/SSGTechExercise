using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSGTechExercise.Startup))]
namespace SSGTechExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
