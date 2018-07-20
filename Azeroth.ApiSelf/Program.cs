using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
namespace Azeroth.ApiSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new System.Web.Http.SelfHost.HttpSelfHostConfiguration("http://localhost:5000"); //配置主机
            
            config.Routes.MapHttpRoute(    //配置路由
                "API Default", "api/{controller}/{id}",
                new { id = System.Web.Http.RouteParameter.Optional });

            using (System.Web.Http.SelfHost.HttpSelfHostServer server = new System.Web.Http.SelfHost.HttpSelfHostServer(config)) //监听HTTP
            {
                
                server.OpenAsync().Wait(); //开启来自客户端的请求
                Console.WriteLine("Press Enter to quit");
                Console.WriteLine("http://localhost:5000/Home/GetAll");
                Console.ReadLine();
            }
        }
    }
}
