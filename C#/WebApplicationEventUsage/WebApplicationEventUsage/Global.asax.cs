using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplicationEventUsage
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Application start variable
            Application["TotalApplications"] = 0;
            Application["TotalSessions"] = 0;
            // Increement TotalApplications by 1
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }

        void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Response.Write(ex);
        }

        void Session_Start(object sender, EventArgs e)
        {
            //increement session count
            Application["TotalSessions"] = (int)Application["TotalSessions"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            //decreement session count
            Application["TotalSessions"] = (int)Application["TotalSessions"] - 1;
        }

    }
}