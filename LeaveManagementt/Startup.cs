using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeaveManagementt.Startup))]
namespace LeaveManagementt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
