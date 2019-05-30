﻿using System.Text;
using SIS.HTTP.Enums;
using SIS.HTTP.Headers;
using SIS.HTTP.Responses;
using SIS.MvcFramework.Result;

namespace SIS.WebServer.Result
{
    public class HtmlResult : ActionResult
    {
        public HtmlResult(string content, HttpResponseStatusCode responseStatusCode = HttpResponseStatusCode.Ok)
            : base(responseStatusCode)
        {
            this.Headers.AddHeader(new HttpHeader("Content-Type", "text/html; charset=utf-8"));
            this.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}
