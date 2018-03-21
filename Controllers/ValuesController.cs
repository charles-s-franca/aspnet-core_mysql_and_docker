using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace BaseApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        BaseAppContext _db;
        public ValuesController(BaseAppContext db)
        {
            this._db = db;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return this._db.users.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
