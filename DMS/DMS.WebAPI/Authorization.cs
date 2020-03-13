using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace DMS.WebAPI
{
    public class Authorization : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (Authorize(actionContext))
            {
                return;
            }
            HandleUnauthorizedRequest(actionContext);
        }

        private static bool Authorize(HttpActionContext actionContext)
        {
            try
            {
                var request = actionContext.Request.Headers.Authorization;
                return !string.IsNullOrEmpty(request?.Scheme) &&
                       request.Scheme == ConfigurationManager.AppSettings["ApiSecureKey"];
            }
            catch (Exception ex)
            {
                //ignore
            }
            return false;
        }

        /// <summary>
        /// Handles the unauthorized request.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        protected override void HandleUnauthorizedRequest(HttpActionContext filterContext)
        {
            if (filterContext == null)
            {
                return;
            }

            filterContext.Response = filterContext.Request.CreateResponse(HttpStatusCode.Unauthorized, new { Message = "API Authentication Failed" }, filterContext.ControllerContext.Configuration.Formatters.JsonFormatter);
            base.HandleUnauthorizedRequest(filterContext);
        }
    }
}