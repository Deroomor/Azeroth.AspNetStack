using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
namespace Azeroth.ApiIIS
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            System.Web.Http.GlobalConfiguration.Configure(config =>
            {
                config.Routes.MapHttpRoute(
        name: "DefaultApi",
        // routeTemplate: "api/{controller}/{id}",
        routeTemplate: "api/{controller}/{action}/",   //控制器/方法/参数
        defaults: new { id = RouteParameter.Optional }
    );
          
            });
        }
    }
}