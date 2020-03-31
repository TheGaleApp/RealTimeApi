using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RealTimeApi.Controllers
{
    /// <summary>
    /// Our thought here was just to get data for what we call a facility.  It would be helpful to get pay and bill rates.  This is a lower priority
    /// 
    /// Obviously the method signatures need to change from IEnumerable<string> to IEnumerable<SomethingElse>  but I don't know what your employee object looks like.
    /// Alternative entity framework (if you're using it) can scaffold up controllers like this for get / post /put operations by 
    /// right clicking controllers->Add->Controller-> and then choosing the option to use entity framework with read/write
    /// 
    /// </summary>
    /// 
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

    }
}
