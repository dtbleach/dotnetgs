using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gs.Core;
using gs.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gs.Controllers
{
    [EnableCors("AllowAll")]
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

        // POST: api/GS
        [HttpPost]
        public void Post([FromBody]lgview v)
        {
            MysqlDbContext db = new MysqlDbContext();
            lg g = new lg
            {
                ip = v.ii,
                gz = v.gg,
                bs = v.bb
            };
            db.LG.Add(g);
            db.SaveChanges();
        }


    }
}
