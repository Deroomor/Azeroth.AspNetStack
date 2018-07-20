using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Azeroth.ApiIISOwin
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        public override void Init()
        {
            this.Error += Global_Error;
            this.EndRequest += Global_EndRequest;
        }

        private void Global_EndRequest(object sender, EventArgs e)
        {
            int b = 44;
            int a = b * 44;
        }

        private void Global_Error(object sender, EventArgs e)
        {
            int a = 3;
            int b = a + 4;
        }
    }
}