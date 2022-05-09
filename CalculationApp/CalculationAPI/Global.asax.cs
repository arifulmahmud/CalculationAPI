using CalculationAPI.Configuration;
using System;
using System.Web.Http;

namespace CalculationAPI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(APIConfig.Register);
        }
    }
}