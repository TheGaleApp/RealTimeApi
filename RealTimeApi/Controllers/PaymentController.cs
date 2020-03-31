using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RealTimeApi.Controllers
{
    /// <summary>
    /// Our goal here is to use this method to generate a payment request.  This would replace the current hours import, and potentially be used for requesting pay advances.
    /// Additionally it would be helpful to be able to perform "get" operations in order to see the data that realtime has for a payment request.
    /// 
    /// Obviously the method signatures need to change from IEnumerable<string> to IEnumerable<SomethingElse>  but I don't know what your employee object looks like.
    /// Alternative entity framework (if you're using it) can scaffold up controllers like this for get / post /put operations by 
    /// right clicking controllers->Add->Controller-> and then choosing the option to use entity framework with read/write
    /// 
    /// </summary>

    public class PaymentController : ApiController
    {
        // GET: api/Payment
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Payment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Payment
        public void Post([FromBody]string value)
        {
        }

      
    }
}
