using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace NopWebApi.CustomFilter
{
    public class AuthorizeFilter:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionExecutedContext)
        {
            //base.OnAuthorization(actionContext);
            if (actionExecutedContext.Request.Headers.Authorization != null)
            {
                var AuthToken = actionExecutedContext.Request.Headers.Authorization.Parameter;
                if (AuthToken == "gkgk")
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(
                        new GenericIdentity("GK"), null);

                }
                else
                {
                    actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
            else
            {
                actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
        }
    }
}