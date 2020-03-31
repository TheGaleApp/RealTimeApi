using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RealTimeApi.Controllers
{
    /// <summary>
    /// Our thought is that this can replace the nurse/employee import and update processes where we are currently submitting this data via api.  
    /// Additionally it would be helpful to be able to perform "get" operations in order to see the data that realtime has for a nurse/employee
    /// 
    /// Obviously the method signatures need to change from IEnumerable<string> to IEnumerable<Employee>  but I don't know what your employee object looks like.
    /// Alternative entity framework (if you're using it) can scaffold up controllers like this for get / post /put operations by 
    /// right clicking controllers->Add->Controller-> and then choosing the option to use entity framework with read/write
    /// 
    /// In the same way the post and put objects need to change from strings to the appropriate object values
    /// </summary>

    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }


    }
}
