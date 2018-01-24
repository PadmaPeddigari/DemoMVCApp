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

			#sWAPNA CHNAGE1

			#Padma change1
			#sWAPNA CHNAGE2
			#Padma change2

        }
    }
}
