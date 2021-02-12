using Ganss.XSS;
using System;
using System.Collections.Generic;
using System.Text;

namespace AradFinal.Core.Securities
{
  public static class XssSecurity
    {
       public static string SanitizerString(this string str)
        {
            var sanitizer = new HtmlSanitizer();
            sanitizer.KeepChildNodes = true;
            sanitizer.AllowDataAttributes = true;

            return sanitizer.Sanitize(str);
        }
    }
}
