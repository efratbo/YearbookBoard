using Microsoft.AspNetCore.Mvc;
using YearbookBoard.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YearbookBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdatesController : ControllerBase
    {
        private static List<Updates> _updates = new List<Updates> { 
            new Updates { UpdateLevel = "",Name = "",Detail = ""} };

        // GET: api/<UpdatesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UpdatesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UpdatesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UpdatesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UpdatesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
