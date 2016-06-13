using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TestApiController : ApiController
    {
        public string Test1()
        {
            return "Hello world!";
        }

        public string Test2(string para)
        {

            return "Hello world! the para is :" + para;
        }

        public void Test111()
        {
            // this func is no use!
        }
    }
}
