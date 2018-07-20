using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Azeroth.ApiOwin
{
    public class ValuesController : ApiController
    {
        //api/valuses/time
        [HttpGet]
        [HttpPost]
        public timeResult time()
        {
            return new timeResult()
            {
                id = DateTime.Now.Ticks,
                time = DateTime.Now,
                remark = DateTime.Now.ToString()
            };
        }
        [HttpGet]
        [HttpPost]
        public dynamic Sleep(int sleep)
        {
            if (sleep < 1 || sleep > 10)
                sleep = 1;
            sleep *= 1000;

            var begionTime = DateTime.Now.ToString("HH:mm:ss");
            System.Threading.Thread.Sleep(sleep);
            var endTime = DateTime.Now.ToString("HH:mm:ss");
            return new
            {
                sleep = sleep,
                begionTime = begionTime,
                endTime = endTime
            };
        }

        // GET api/values 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
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