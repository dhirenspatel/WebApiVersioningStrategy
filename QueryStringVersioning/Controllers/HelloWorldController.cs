using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QueryStringVersioning.Controllers
{
    [RoutePrefix("api/helloworld")]
    public class HelloWorldController : ApiController
    {
        [Route]
        public string Get() => "Hello world!";
    }
    [ApiVersion("2.0")]
    [RoutePrefix("api/helloworld")]
    public class HelloWorld2Controller : ApiController
    {
        [Route]
        public string Get() => "Hello world!";
    }
}
