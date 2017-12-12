using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstHeroku.Startup))]
namespace MyFirstHeroku
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
