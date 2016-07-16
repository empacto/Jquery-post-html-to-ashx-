using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQPostHtmlToAshx.controller
{
    /// <summary>
    /// Summary description for ReceivePostWriteToFile
    /// </summary>
    public class ReceivePostWriteToFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}