using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(JokesApi.Web.Startup))]

namespace JokesApi.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
