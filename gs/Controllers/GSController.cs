using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gs.Core;
using gs.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GSController : ControllerBase
    {
        // GET: api/GS
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GS/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GS
        [HttpPost]
        public void Post(string ii,string gg,string bb)
        {
            MysqlDbContext db = new MysqlDbContext();      
            lg g = new lg();
            g.ip = ii;
            g.gz = gg;
            g.bs = bb;
            db.LG.Add(g);
            db.SaveChanges();
            db.Dispose();
        }

        // PUT: api/GS/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
