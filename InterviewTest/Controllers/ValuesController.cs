using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new List<string> { "value1", "value2" };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= values.Count)
            {
                return NotFound();
            }
            return values[id];
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            values.Add(value);
            
            var newId = values.Count - 1;
            return CreatedAtAction(nameof(Get), new { id = newId }, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= values.Count)
            {
                return NotFound();
            }
            values[id] = value;
            e
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
            {
                return NotFound();
            }
            values.RemoveAt(id);
            
            return NoContent();
        }
    }

}
