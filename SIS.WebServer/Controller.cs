using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.MvcFramework.Identity;
using SIS.MvcFramework.Result;
using SIS.WebServer.Result;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace SIS.MvcFramework
{
    public abstract class Controller
    {
        protected Controller()
        {
            this.ViewData = new Dictionary<string, object>();
        }

        protected Dictionary<string, object> ViewData;

        public Principal User =>
            this.Request.Session.ContainsParameter("principal")
            ? (Principal)this.Request.Session.GetParameter("principal")
            : null;

        public IHttpRequest Request { get; set; }

        private string ParseTemplate(string viewContent)
        {
            foreach (var param in this.ViewData)
            {
                viewContent = viewContent.Replace($"@Model.{param.Key}", param.Value.ToString());
            }

            return viewContent;
        }

        protected bool IsLoggedIn()
        {
            return this.Request.Session.ContainsParameter("principal");
        }

        protected void SignIn(string id, string username, string email)
        {
            this.Request.Session.AddParameter("principal", new Principal
            {
                Id = id,
                Username = username,
                Email = email
            });
        }

        protected void SignOut()
        {
            this.Request.Session.ClearParameters();
        }

        protected ActionResult View([CallerMemberName] string view = null)
        {
            string controllerName = GetType().Name.Replace("Controller", string.Empty);
            string viewName = view;

            string viewContent = File.ReadAllText("Views/" + controllerName + "/" + viewName + ".html");
            viewContent = ParseTemplate(viewContent);

            //string layoutContent = File.ReadAllText("Views/_Layout.html");
            //layoutContent = ParseTemplate(layoutContent);
            //layoutContent = layoutContent.Replace("@RenderBody()", viewContent);

            var htmlResult = new HtmlResult(viewContent);

            return htmlResult;
        }

        protected ActionResult Redirect(string url)
        {
            return new RedirectResult(url);
        }
    }
}
