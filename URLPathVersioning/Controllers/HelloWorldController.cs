using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace URLPathVersioning.Controllers
{
    #region Version 1
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/helloworld")]
    public class HelloWorldController : ApiController
    {
        public string Get()
        {
            return "Hello World V1";
        }
    }
    #endregion

    #region Version 2
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/helloworld")]
    public class HelloWorld2Controller : ApiController
    {
        public string Get()
        {
            return "Hello World V2";
        }
    }
    #endregion

    #region Version 3 & 4
    [ApiVersion("3.0")]
    [ApiVersion("4.0")]
    [Route("api/v{version:apiVersion}/helloworld")]
    public class HelloWorld3Controller : ApiController
    {
        public string Get()
        {
            return "Hello World V3";
        }
        [MapToApiVersion("4.0")]
        public string GetV4()
        {
            return "Hello World V4";
        }
    }
    #endregion
}
