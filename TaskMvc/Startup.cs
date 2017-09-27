using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskMvc.Startup))]
namespace TaskMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
