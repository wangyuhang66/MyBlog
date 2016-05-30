using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBlogBackground.Startup))]
namespace MyBlogBackground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
