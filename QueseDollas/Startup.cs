using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QueseDollas.Startup))]
namespace QueseDollas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
