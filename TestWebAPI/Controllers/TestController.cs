using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;

namespace TestWebAPI.Controllers
{
    public class TestController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value".Trimmer(new List<string> {"a", "e", "i" });
        }
        
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

    }

    public static class Ext
    {
        public static string Trimmer(this string str, IEnumerable<string> chars)
        {
            return chars.Aggregate(str, (s, a) => s.Replace(a, ""));
        }
    }
}