using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoMVCApp.Startup))]
namespace DemoMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
<<<<<<< HEAD
			#sWAPNA CHNAGE1
=======
			#Padma change1
>>>>>>> 34a0601e390697cd575ce1070117a6d470e0a937
        }
    }
}
