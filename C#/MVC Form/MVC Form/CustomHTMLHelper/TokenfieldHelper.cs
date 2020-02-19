using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Form.CustomHTMLHelper
{
    public static class TokenfieldHelper
    {
        public static IHtmlString Tokenfield(this HtmlHelper htmlHelper, string setTokens)
        {
            TagBuilder tagBuilder = new TagBuilder("tokenfield");
            tagBuilder.Attributes.Add("setTokens", VirtualPathUtility.ToAbsolute(setTokens));
            return new MvcHtmlString(tagBuilder.ToString(TagRenderMode.SelfClosing));
        }
    }
}