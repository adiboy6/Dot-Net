using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC_Form.CustomHTMLHelper
{
    public static class TokenfieldHelper
    {
        public static MvcHtmlString Tokenfield(this HtmlHelper htmlHelper, string setTokens)
        {
            StringBuilder script = new StringBuilder();
            
            script.AppendLine(@"<script>");
            script.AppendLine("$(\'#" + setTokens + "\').tokenfield({" +
                "autocomplete: {" +
                "source: ['red', 'blue', 'green', 'yellow', 'violet', 'brown', 'purple', 'black', 'white'],"+
                "delay: 100},"+
                "showAutocompleteOnFocus: true})");
            script.AppendLine(@"</script>");
            return new MvcHtmlString(script.ToString());
        }
    }
}