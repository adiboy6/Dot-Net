using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEventUsage
{
    public partial class EventPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number of Applications : " + Application["TotalApplications"]);
            Response.Write("<br>");
            Response.Write("Number of Sessions Online : " + Application["TotalSessions"]);
            try
            {
                throw new ApplicationException();
            }
            catch (Exception ex)
            {
            }
        }
    }
}