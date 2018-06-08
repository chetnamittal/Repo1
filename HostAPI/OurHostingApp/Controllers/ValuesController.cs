using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HostAPI;

namespace OurHostingApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //This method for now is callling the HostAPI Internally. We shall not do any procesing here.
        public bool Get(int id)
        {

            //This Get Method is used to call the Invoking class. "OurHostingApp" is the API. This has reference to "HostAPI" 
            //which actually has the logic to call different types of application

            IInvokingClass c1 = new InvokingClass("Console");
            return c1.InvokeProperApplication();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
