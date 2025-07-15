using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // In-memory list for demo purposes
        private static List<string> values = new List<string> { "Krishna", "Siva" };

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(values); // Returns 200 OK with the list
        }

        // POST: api/values
        [HttpPost]
        public ActionResult<IEnumerable<string>> Post([FromBody] string value)
        {
            values.Add(value);
            return Ok(values); // Returns updated list
        }
    }
}
