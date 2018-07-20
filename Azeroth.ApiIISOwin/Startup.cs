using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Threading;

[assembly: OwinStartup(typeof(Azeroth.ApiIISOwin.Startup))]

namespace Azeroth.ApiIISOwin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            System.Web.Http.HttpConfiguration config = new System.Web.Http.HttpConfiguration();
            config.Routes.MapHttpRoute("r1", "{controller}/{action}/{id}/", defaults: new { id = RouteParameter.Optional });
            config.Filters.Add(new AzFilter());
            
            app.UseWebApi(config);

            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }

    public class AzFilter : System.Web.Http.Filters.IExceptionFilter
    {
        public bool AllowMultiple
        {
            get
            {
                return true;
            }
        }

        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new System.Net.Http.StringContent("hello world"),
        };
            return System.Threading.Tasks.Task.FromResult(string.Empty);
        }
    }
}
