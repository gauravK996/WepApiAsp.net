using NopWebApi.CustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace NopWebApi.Controllers
{
    [AuthorizeFilter]
    public class StudentController:ApiController
    {
        public IHttpActionResult Get(int Id)
        {
            return Ok("ggggggggg");
        }
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        [HttpPost]       
        public IHttpActionResult Get(string Name)
        {
            return new CustomReturn(Name, Request);
        }
    }
}