using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elmah;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                throw new Exception("Some error");
            }
            catch (Exception ex)
            {
                ex.Data.Add("Key is", "Value is");
                ErrorSignal.FromCurrentContext().Raise(ex);
            }
            try
            {
                throw new DivideByZeroException("Some error");
            }
            catch (Exception ex)
            {
                ex.Data.Add("Key is", "Value is");
                ErrorSignal.FromCurrentContext().Raise(ex);
            }

        }
    }
}