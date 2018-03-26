using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace DevDefined.OAuth.Core.Framework
{
    public class HttpRequestWrapper : HttpRequestBase
    {
        public HttpRequestWrapper(HttpRequest httpRequest)
        {
        }
    }
}
