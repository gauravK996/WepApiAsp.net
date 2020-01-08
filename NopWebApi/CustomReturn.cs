using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NopWebApi
{
    public class CustomReturn : IHttpActionResult
    {
        string _Value;
        HttpRequestMessage _requestMessage;
        public CustomReturn(string Value,HttpRequestMessage httpRequestMessage)
        {
            _Value = Value;
            _requestMessage = httpRequestMessage;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var Response = new HttpResponseMessage()
            {
                Content = new StringContent(_Value),
                RequestMessage=_requestMessage

            };
            //throw new NotImplementedException();
            return Task.FromResult(Response);
        }
    }
}