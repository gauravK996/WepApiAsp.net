using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http.Filters;

namespace NopWebApi.CustomFilter
{
    public class ExceptionFilter:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {


            //base.OnException(actionExecutedContext);
        }
    }
}