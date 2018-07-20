using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeroth.ApiOwin
{
    class Program
    {
        static void Main(string[] args)
        {
            //监听地址
            string baseAddress = string.Format("http://{0}:{1}/",
                System.Configuration.ConfigurationManager.AppSettings.Get("Domain"),
                System.Configuration.ConfigurationManager.AppSettings.Get("Port"));

            //启动监听
            using (Microsoft.Owin.Hosting.WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("host 已启动：{0}", DateTime.Now);
                Console.WriteLine("访问：{0}/page/index.html", baseAddress);
                Console.ReadLine();
            }
        }

    }
}
