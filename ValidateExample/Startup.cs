using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidateExample.Startup))]
namespace ValidateExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
